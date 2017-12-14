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


    public class EntityTranslatorBuilder<TResult, TInput, TSchema> :
        IEntityTranslatorBuilder<TResult, TInput, TSchema>,
        TranslatorFactoryContext<TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly TranslatorFactoryContext<TSchema> _context;
        readonly ITranslatorBuilderPropertyScanner<TSchema> _propertyScanner;
        readonly IDictionary<string, IPropertyTranslatorBuilder<TResult, TInput, TSchema>> _propertyTranslaters;
        readonly string _translateName;

        Func<ITranslateBuilderPropertyVisitor<TSchema>> _defaultPropertyVisitor;

        public EntityTranslatorBuilder(TranslatorFactoryContext<TSchema> context, string translateName)
        {
            ImplementationType = context.GetImplementationType<TResult>();
            _context = context;
            _translateName = translateName;

            _propertyTranslaters = new Dictionary<string, IPropertyTranslatorBuilder<TResult, TInput, TSchema>>();

            CopyPropertyVisitor = new EntityCopyTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(this);
            MissingPropertyVisitor = new EntityMissingTranslateBuilderPropertyVisitor<TResult, TInput, TSchema>(this);

            ITranslateBuilderPropertyVisitor<TSchema> DefaultPropertyVisitor()
            {
                return CopyPropertyVisitor;
            }

            _defaultPropertyVisitor = DefaultPropertyVisitor;

            _propertyScanner = new EntityTranslatorBuilderPropertyScanner<TResult, TInput, TSchema>();
        }

        public ITranslateBuilderPropertyVisitor<TSchema> CopyPropertyVisitor { private get; set; }
        public ITranslateBuilderPropertyVisitor<TSchema> MissingPropertyVisitor { private get; set; }

        public Type ImplementationType { get; }

        public IEntityTranslator<TIn, TSchema> GetEntityTranslator<T, TIn, TTranslation>()
            where T : TSchema
            where TIn : TSchema
            where TTranslation : IEntityTranslatorSpecification<T, TIn, TSchema>, new()
        {
            return _context.GetEntityTranslator<T, TIn, TTranslation>();
        }

        public IEntityTranslator<TIn, TSchema> CreateEntityTranslator<T, TIn>(IEntityTranslatorSpecification<T, TIn, TSchema> specification)
            where T : TSchema
            where TIn : TSchema
        {
            return _context.CreateEntityTranslator(specification);
        }

        public void Add(string propertyName, IPropertyTranslator<TResult, TInput, TSchema> translator)
        {
            if (!_propertyTranslaters.TryGetValue(propertyName, out var propertyBuilder))
            {
                propertyBuilder = new PropertyTranslatorBuilder<TResult, TInput, TSchema>();
                _propertyTranslaters[propertyName] = propertyBuilder;
            }

            propertyBuilder.Add(translator);
        }

        public void CopyAll()
        {
            Clear();

            ITranslateBuilderPropertyVisitor<TSchema> DefaultPropertyVisitor()
            {
                return CopyPropertyVisitor;
            }

            _defaultPropertyVisitor = DefaultPropertyVisitor;
        }

        public void ExcludeAll()
        {
            Clear();

            ITranslateBuilderPropertyVisitor<TSchema> DefaultPropertyVisitor()
            {
                return MissingPropertyVisitor;
            }

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

        bool TranslatorFactoryContext<TSchema>.TryGetEntityFactory<T>(out IEntityFactory<T> factory)
        {
            return _context.TryGetEntityFactory(out factory);
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