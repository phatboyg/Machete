namespace Machete.TranslateConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Extensions;
    using Translators;
    using Visitors;


    public class TranslateBuilder<TResult, TInput, TSchema> :
        ITranslateBuilder<TResult, TInput, TSchema>,
        TranslateFactoryContext<TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly TranslateFactoryContext<TSchema> _context;
        readonly ITranslateBuilderPropertyScanner<TSchema> _propertyScanner;
        readonly IDictionary<string, IPropertyTranslateBuilder<TResult, TInput, TSchema>> _propertyTranslaters;

        ITranslateBuilderPropertyVisitor<TSchema> _defaultPropertyVisitor;

        public TranslateBuilder(TranslateFactoryContext<TSchema> context)
        {
            ImplementationType = context.GetImplementationType<TResult>();
            _context = context;

            _propertyTranslaters = new Dictionary<string, IPropertyTranslateBuilder<TResult, TInput, TSchema>>();

            _defaultPropertyVisitor = new EntityCopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(this);
            _propertyScanner = new EntityTranslateBuilderPropertyScanner<TResult, TInput, TSchema>();
        }

        public ITranslateBuilderPropertyVisitor<TSchema> CopyPropertyVisitor { get; set; }
        public ITranslateBuilderPropertyVisitor<TSchema> MissingPropertyVisitor { get; set; }

        public Type ImplementationType { get; }

        public void Add(string propertyName, IPropertyTranslator<TResult, TInput, TSchema> translator)
        {
            IPropertyTranslateBuilder<TResult, TInput, TSchema> propertyBuilder;
            if (!_propertyTranslaters.TryGetValue(propertyName, out propertyBuilder))
            {
                propertyBuilder = new PropertyTranslateBuilder<TResult, TInput, TSchema>();
                _propertyTranslaters[propertyName] = propertyBuilder;
            }

            propertyBuilder.Add(translator);
        }

        public void CopyAll()
        {
            Clear();

            _defaultPropertyVisitor = new EntityCopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(this);
        }

        public void ExcludeAll()
        {
            Clear();

            _defaultPropertyVisitor = new EntityMissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(this);
        }

        public void Clear()
        {
            foreach (var builder in _propertyTranslaters)
                builder.Value.Clear();
        }

        public void Clear(string propertyName)
        {
            IPropertyTranslateBuilder<TResult, TInput, TSchema> builder;
            if (_propertyTranslaters.TryGetValue(propertyName, out builder))
                builder.Clear();
        }

        bool TranslateFactoryContext<TSchema>.TryGetEntityFactory<T>(out IEntityFactory<T> factory)
        {
            return _context.TryGetEntityFactory(out factory);
        }

        ITranslator<T, TSchema> TranslateFactoryContext<TSchema>.GetTranslator<T>(Type translateSpecificationType, Func<ITranslateFactory<T, TSchema>> translateFactory)
        {
            return _context.GetTranslator(translateSpecificationType, translateFactory);
        }

        public Type GetImplementationType<T>()
        {
            return _context.GetImplementationType<T>();
        }

        public ITranslator<TInput, TSchema> Build()
        {
            IEntityFactory<TResult> entityFactory;
            if (!_context.TryGetEntityFactory(out entityFactory))
                throw new MacheteException($"The entity factory was not found: {TypeCache<TResult>.ShortName}");

            AddDefaultPropertyTranslators();

            return new EntityTranslator<TResult, TInput, TSchema>(entityFactory, _propertyTranslaters.Values.Select(x => x.Build()).ToList());
        }

        void AddDefaultPropertyTranslators()
        {
            var propertyTranslatersKeys = _propertyTranslaters.Where(x => x.Value.IsDefined).Select(x => x.Key).ToList();

            _propertyScanner.ScanProperties(new HashSet<string>(propertyTranslatersKeys), _defaultPropertyVisitor);
        }
    }
}