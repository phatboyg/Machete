namespace Machete.TranslatorConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Extensions;
    using Translators;
    using Translators.EntityTranslators;
    using Translators.PropertyTranslators;
    using Visitors;


    public class EntityCreatorBuilder<TResult, TSchema> :
        IEntityCreatorBuilder<TResult, TSchema>,
        CreatorFactoryContext<TSchema>
        where TResult : TSchema
        where TSchema : Entity
    {
        readonly CreatorFactoryContext<TSchema> _context;
        readonly ITranslatorBuilderPropertyScanner<TSchema> _propertyScanner;
        readonly IDictionary<string, IPropertyTranslatorBuilder<TResult, TSchema>> _propertyTranslaters;
        readonly string _creatorName;

        readonly Func<ITranslateBuilderPropertyVisitor<TSchema>> _defaultPropertyVisitor;

        public EntityCreatorBuilder(CreatorFactoryContext<TSchema> context, string creatorName)
        {
            _context = context;
            _creatorName = creatorName;


            _propertyTranslaters = new Dictionary<string, IPropertyTranslatorBuilder<TResult, TSchema>>();

            MissingPropertyVisitor = new EntityMissingCreatorBuilderPropertyVisitor<TResult, TSchema>(this);

            ITranslateBuilderPropertyVisitor<TSchema> DefaultPropertyVisitor()
            {
                return MissingPropertyVisitor;
            }

            _defaultPropertyVisitor = DefaultPropertyVisitor;

            _propertyScanner = new EntityTranslatorBuilderPropertyScanner<TResult, TSchema>();
        }

        public ITranslateBuilderPropertyVisitor<TSchema> MissingPropertyVisitor { private get; set; }

        bool CreatorFactoryContext<TSchema>.TryGetEntityFactory<T>(out IEntityFactory<T> factory)
        {
            return _context.TryGetEntityFactory(out factory);
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
            if (!_propertyTranslaters.TryGetValue(propertyName, out var propertyBuilder))
            {
                propertyBuilder = new PropertyTranslatorBuilder<TResult, TSchema>();
                _propertyTranslaters[propertyName] = propertyBuilder;
            }

            propertyBuilder.Add(translator);
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

        public IEntityCreator<TSchema> Build()
        {
            if (!_context.TryGetEntityFactory(out IEntityFactory<TResult> entityFactory))
                throw new MacheteException($"The entity factory was not found: {TypeCache<TResult>.ShortName}");

            AddDefaultPropertyTranslators();

            return new EntityCreator<TResult, TSchema>(_creatorName, entityFactory, _propertyTranslaters.Values.Select(x => x.Build()).ToList());
        }

        void AddDefaultPropertyTranslators()
        {
            var propertyTranslatersKeys = _propertyTranslaters.Where(x => x.Value.IsDefined).Select(x => x.Key).ToList();

            _propertyScanner.ScanProperties(new HashSet<string>(propertyTranslatersKeys), _defaultPropertyVisitor());
        }
    }
}