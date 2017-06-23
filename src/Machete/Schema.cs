namespace Machete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Internals.Reflection;


    public static class Schema
    {
        public static readonly ISchemaFactorySelector Factory = new UnusedSchemaFactorySelector();


        class UnusedSchemaFactorySelector :
            ISchemaFactorySelector
        {
        }
    }


    /// <summary>
    /// A schema contains the entities and mappings used to convert parsed content into entities
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public class Schema<TEntity> :
        ISchema<TEntity>
        where TEntity : Entity
    {
        readonly IDictionary<Type, IEntityConverter> _entityMaps;
        readonly IDictionary<Type, IEntityFactory> _entityFactories;
        readonly IEntityTypeSelector _entityTypeSelector;
        readonly IImplementationBuilder _implementationBuilder;

        public Schema(IEnumerable<IEntityConverter> entities, IEntityTypeSelector entityTypeSelector, IImplementationBuilder implementationBuilder)
        {
            _entityTypeSelector = entityTypeSelector;
            _implementationBuilder = implementationBuilder;

            IEntityConverter[] converters = entities as IEntityConverter[] ?? entities.ToArray();

            _entityMaps = converters.ToDictionary(x => x.EntityType.EntityType);
            _entityFactories = converters.ToDictionary(x => x.EntityType.EntityType, x => x.Factory);
        }

        public bool TryMapEntity<T>(TextSlice slice, out T entity)
            where T : TEntity
        {
            EntityType entityType;
            if (_entityTypeSelector.SelectEntityType(slice, out entityType))
            {
                IEntityConverter entityConverter;
                if (_entityMaps.TryGetValue(entityType.EntityType, out entityConverter))
                {
                    entity = entityConverter.GetEntity<T>(slice);
                    return true;
                }
            }

            entity = default(T);
            return false;
        }

        public bool TryGetEntityFactory<T>(out IEntityFactory<T> entityFactory)
            where T : TEntity
        {
            IEntityFactory factory;
            if (_entityFactories.TryGetValue(typeof(T), out factory))
            {
                entityFactory = factory as IEntityFactory<T>;
                return entityFactory != null;
            }

            // TODO create if possible
            entityFactory = null;
            return false;
        }

        public Type GetImplementationType<T>()
        {
            return _implementationBuilder.GetImplementationType(typeof(T));
        }
    }
}