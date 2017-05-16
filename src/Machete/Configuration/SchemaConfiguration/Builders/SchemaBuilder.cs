namespace Machete.SchemaConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using Internals.Reflection;
    using TypeSelectors;


    public class SchemaBuilder<TSchema> :
        ISchemaBuilder<TSchema>
        where TSchema : Entity
    {
        readonly IDictionary<Type, IEntityMap> _entityMaps;
        readonly IImplementationBuilder _implementationBuilder;
        readonly IEntityTypeSelectorFactory _entityTypeSelectorFactory;

        public SchemaBuilder(IEntityTypeSelectorFactory entityTypeSelectorFactory)
        {
            _entityTypeSelectorFactory = entityTypeSelectorFactory;
            _entityMaps = new Dictionary<Type, IEntityMap>();
            _implementationBuilder = new DynamicImplementationBuilder();
        }

        public Type GetImplementationType<T>()
            where T : TSchema
        {
            return _implementationBuilder.GetImplementationType(typeof(T));
        }

        public IEntityMap<T> GetEntityMap<T>()
            where T : TSchema
        {
            IEntityMap result;
            if (_entityMaps.TryGetValue(typeof(T), out result))
            {
                return result as IEntityMap<T>;
            }

            throw new KeyNotFoundException($"The {typeof(T).Name} entity map was not found");
        }

        public void Add<T>(IEntityMap<T> map)
            where T : TSchema
        {
            _entityMaps[map.EntityType.EntityType] = map;

            if(map.EntityType.EntityTypeSelector != null)
                _entityTypeSelectorFactory.Add(map.EntityType);
        }

        public ISchema<TSchema> Build()
        {
            var entityTypeSelector = _entityTypeSelectorFactory.Build();

            return new Schema<TSchema>(_entityMaps.Values, entityTypeSelector, _implementationBuilder);
        }
    }
}