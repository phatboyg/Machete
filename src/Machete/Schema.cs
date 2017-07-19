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
    /// <typeparam name="TSchema">The entity type</typeparam>
    public class Schema<TSchema> :
        ISchema<TSchema>
        where TSchema : Entity
    {
        readonly IDictionary<Type, IEntityConverter> _entityConverters;
        readonly IDictionary<Type, IEntityFactory> _entityFactories;
        readonly IDictionary<Type, ILayoutParserFactory> _layouts;
        readonly IEntitySelector _entitySelector;
        readonly IImplementationBuilder _implementationBuilder;

        public Schema(IEnumerable<IEntityConverter> entities,IEnumerable<ILayoutParserFactory> layouts, IEntitySelector entitySelector, IImplementationBuilder implementationBuilder)
        {
            _entitySelector = entitySelector;
            _implementationBuilder = implementationBuilder;

            IEntityConverter[] entityConverters = entities as IEntityConverter[] ?? entities.ToArray();

            _entityConverters = entityConverters.ToDictionary(x => x.EntityInfo.EntityType);
            _entityFactories = entityConverters.ToDictionary(x => x.EntityInfo.EntityType, x => x.Factory);
            _layouts = layouts.ToDictionary(x => x.LayoutType);
        }

        public bool TryConvertEntity<T>(TextSlice slice, out T entity)
            where T : TSchema
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

        public bool TryGetLayout<T>(out ILayoutParserFactory<T, TSchema> result)
            where T : Layout
        {
            ILayoutParserFactory layoutParserFactory;
            if (_layouts.TryGetValue(typeof(T), out layoutParserFactory))
            {
                result = layoutParserFactory as ILayoutParserFactory<T, TSchema>;
                return result != null;
            }

            result = null;
            return false;
        }

        public bool TryGetEntityFactory<T>(out IEntityFactory<T> entityFactory)
            where T : TSchema
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