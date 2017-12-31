namespace Machete.TranslatorConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Internals.Extensions;
    using Translators;
    using Translators.EntityTranslators;
    using Translators.PropertyTranslators;
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

            _propertyScanner = new EntityTranslatorBuilderPropertyScanner<TResult, TSchema>();
        }

        public ITranslateBuilderPropertyVisitor<TSchema> CopyPropertyVisitor { private get; set; }
        public ITranslateBuilderPropertyVisitor<TSchema> MissingPropertyVisitor { private get; set; }

        bool CreatorFactoryContext<TSchema>.TryGetEntityFactory<T>(out IEntityFactory<T> factory)
        {
            return _context.TryGetEntityFactory(out factory);
        }

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

        public IEntityCreator<TSchema> GetEntityCreator<T, TDescription>()
            where T : TSchema
            where TDescription : IEntityCreatorSpecification<T, TSchema>, new()
        {
            return _context.GetEntityCreator<T, TDescription>();
        }

        public IEntityCreator<TSchema> CreateEntityCreator<T>(IEntityCreatorSpecification<T, TSchema> specification)
            where T : TSchema
        {
            return _context.CreateEntityCreator(specification);
        }

        public void Add(string propertyName, IPropertyTranslator<TResult, TSchema> translator)
        {
            var proxy = new PropertyTranslatorProxy(translator);

            Add(propertyName, proxy);
        }

        public void Add(string propertyName, IInputPropertyTranslator<TResult, TInput, TSchema> translator)
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


        class PropertyTranslatorProxy :
            IInputPropertyTranslator<TResult, TInput, TSchema>
        {
            readonly IPropertyTranslator<TResult, TSchema> _translator;

            public PropertyTranslatorProxy(IPropertyTranslator<TResult, TSchema> translator)
            {
                _translator = translator;
            }

            public Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
            {
                return _translator.Apply(entity, context);
            }
        }
    }
}