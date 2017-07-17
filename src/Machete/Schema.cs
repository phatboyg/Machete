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
        readonly IDictionary<Type, IEntityConverter> _entityConverters;
        readonly IDictionary<Type, IEntityFactory> _entityFactories;
        readonly IEntitySelector _entitySelector;
        readonly IImplementationBuilder _implementationBuilder;

        public Schema(IEnumerable<IEntityConverter> entities, IEntitySelector entitySelector, IImplementationBuilder implementationBuilder)
        {
            _entitySelector = entitySelector;
            _implementationBuilder = implementationBuilder;

            IEntityConverter[] entityConverters = entities as IEntityConverter[] ?? entities.ToArray();

            _entityConverters = entityConverters.ToDictionary(x => x.EntityInfo.EntityType);
            _entityFactories = entityConverters.ToDictionary(x => x.EntityInfo.EntityType, x => x.Factory);
        }

        public bool TryConvertEntity<T>(TextSlice slice, out T entity)
            where T : TEntity
        {
            EntityInfo entityInfo;
            if (_entitySelector.SelectEntity(slice, out entityInfo))
            {
                IEntityConverter entityConverter;
                if (_entityConverters.TryGetValue(entityInfo.EntityType, out entityConverter))
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