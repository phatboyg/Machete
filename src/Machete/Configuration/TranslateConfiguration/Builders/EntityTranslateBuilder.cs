namespace Machete.TranslateConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Extensions;
    using Translators;
    using Translators.EntityTranslators;
    using Translators.PropertyTranslaters;
    using Visitors;


    public class EntityTranslateBuilder<TResult, TInput, TSchema> :
        IEntityTranslateBuilder<TResult, TInput, TSchema>,
        TranslateFactoryContext<TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly TranslateFactoryContext<TSchema> _context;
        readonly string _translateName;
        readonly ITranslateBuilderPropertyScanner<TSchema> _propertyScanner;
        readonly IDictionary<string, IPropertyTranslateBuilder<TResult, TInput, TSchema>> _propertyTranslaters;

        Func<ITranslateBuilderPropertyVisitor<TSchema>> _defaultPropertyVisitor;

        public EntityTranslateBuilder(TranslateFactoryContext<TSchema> context, string translateName)
        {
            ImplementationType = context.GetImplementationType<TResult>();
            _context = context;
            _translateName = translateName;

            _propertyTranslaters = new Dictionary<string, IPropertyTranslateBuilder<TResult, TInput, TSchema>>();

            CopyPropertyVisitor = new EntityCopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(this);
            MissingPropertyVisitor = new EntityMissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(this);

            ITranslateBuilderPropertyVisitor<TSchema> DefaultPropertyVisitor() => CopyPropertyVisitor;

            _defaultPropertyVisitor = DefaultPropertyVisitor;
            
            _propertyScanner = new EntityTranslateBuilderPropertyScanner<TResult, TInput, TSchema>();
        }

        public ITranslateBuilderPropertyVisitor<TSchema> CopyPropertyVisitor { private get; set; }
        public ITranslateBuilderPropertyVisitor<TSchema> MissingPropertyVisitor { private get; set; }

        public Type ImplementationType { get; }

        public void Add(string propertyName, IPropertyTranslator<TResult, TInput, TSchema> translator)
        {
            if (!_propertyTranslaters.TryGetValue(propertyName, out var propertyBuilder))
            {
                propertyBuilder = new PropertyTranslateBuilder<TResult, TInput, TSchema>();
                _propertyTranslaters[propertyName] = propertyBuilder;
            }

            propertyBuilder.Add(translator);
        }

        public void CopyAll()
        {
            Clear();

            ITranslateBuilderPropertyVisitor<TSchema> DefaultPropertyVisitor() => CopyPropertyVisitor;

            _defaultPropertyVisitor = DefaultPropertyVisitor;
        }

        public void ExcludeAll()
        {
            Clear();

            ITranslateBuilderPropertyVisitor<TSchema> DefaultPropertyVisitor() => MissingPropertyVisitor;

            _defaultPropertyVisitor = DefaultPropertyVisitor;
        }

        public void Clear()
        {
            foreach (var builder in _propertyTranslaters)
                builder.Value.Clear();
        }

        public void Clear(string propertyName)
        {
            if (_propertyTranslaters.TryGetValue(propertyName, out var builder))
                builder.Clear();
        }

        bool TranslateFactoryContext<TSchema>.TryGetEntityFactory<T>(out IEntityFactory<T> factory)
        {
            return _context.TryGetEntityFactory(out factory);
        }

        public IEntityTranslator<TI, TSchema> GetEntityTranslator<TR, TI>(Type translateSpecificationType,
            Func<IEntityTranslateSpecification<TR, TI, TSchema>> specificationFactory)
            where TR : TSchema
            where TI : TSchema
        {
            return _context.GetEntityTranslator(translateSpecificationType, specificationFactory);
        }

        public Type GetImplementationType<T>()
        {
            return _context.GetImplementationType<T>();
        }

        public IEntityTranslator<TInput, TSchema> Build()
        {
            if (!_context.TryGetEntityFactory(out IEntityFactory<TResult> entityFactory))
                throw new MacheteException($"The entity factory was not found: {TypeCache<TResult>.ShortName}");

            AddDefaultPropertyTranslators();

            return new EntityTranslator<TResult, TInput, TSchema>(_translateName, entityFactory, _propertyTranslaters.Values.Select(x => x.Build()).ToList());
        }

        void AddDefaultPropertyTranslators()
        {
            var propertyTranslatersKeys = _propertyTranslaters.Where(x => x.Value.IsDefined).Select(x => x.Key).ToList();

            _propertyScanner.ScanProperties(new HashSet<string>(propertyTranslatersKeys), _defaultPropertyVisitor());
        }
    }
}