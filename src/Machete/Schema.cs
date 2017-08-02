namespace Machete
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;
    using Entities;
    using Internals.Reflection;
    using Layouts;
    using TranslateConfiguration;
    using Translators;


    public static class Schema
    {
        public static readonly ISchemaFactorySelector Factory = new UnusedSchemaFactorySelector();


        class UnusedSchemaFactorySelector :
            ISchemaFactorySelector
        {
        }


        public static class Entity
        {
            public static Entity<T> Missing<T>()
                where T : Machete.Entity
            {
                return EntitySchemaCached<T>.MissingEntity;
            }


            static class EntitySchemaCached<T>
                where T : Machete.Entity
            {
                public static readonly Entity<T> MissingEntity = GetMissingEntity();

                static Entity<T> GetMissingEntity()
                {
                    return new MissingEntity<T>();
                }
            }
        }

        public static class Layout
        {
            public static Layout<T> Missing<T>()
                where T : Machete.Layout
            {
                return LayoutSchemaCached<T>.MissingLayout;
            }


            static class LayoutSchemaCached<T>
                where T : Machete.Layout
            {
                public static readonly Layout<T> MissingLayout = GetMissingLayout();

                static Layout<T> GetMissingLayout()
                {
                    return new MissingLayout<T>();
                }
            }
        }
    }


    /// <summary>
    /// A schema contains the entities and mappings used to convert parsed content into entities
    /// </summary>
    /// <typeparam name="TSchema">The entity type</typeparam>
    public class Schema<TSchema> :
        ISchema<TSchema>,
        TranslateFactoryContext<TSchema>
        where TSchema : Entity
    {
        readonly IDictionary<Type, IEntityConverter> _entityConverters;
        readonly IDictionary<Type, IEntityFactory> _entityFactories;
        readonly IDictionary<Type, ILayoutParserFactory> _layouts;
        readonly ConcurrentDictionary<Type, ICachedTranslator> _translators;
        readonly IEntitySelector _entitySelector;
        readonly IImplementationBuilder _implementationBuilder;
        readonly ITranslateFactoryProvider<TSchema> _translateFactoryProvider;

        public Schema(IEnumerable<IEntityConverter> entities, IEnumerable<ILayoutParserFactory> layouts, IEntitySelector entitySelector,
            IImplementationBuilder implementationBuilder, ITranslateFactoryProvider<TSchema> translateFactoryProvider)
        {
            _entitySelector = entitySelector;
            _implementationBuilder = implementationBuilder;
            _translateFactoryProvider = translateFactoryProvider;

            IEntityConverter[] entityConverters = entities as IEntityConverter[] ?? entities.ToArray();

            _entityConverters = entityConverters.ToDictionary(x => x.EntityInfo.EntityType);
            _entityFactories = entityConverters.ToDictionary(x => x.EntityInfo.EntityType, x => x.Factory);
            _layouts = layouts.ToDictionary(x => x.LayoutType);

            _translators = new ConcurrentDictionary<Type, ICachedTranslator>();
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

        public ITranslator<TInput, TSchema> CreateTranslator<TResult, TInput>(Type translateSpecificationType,
            Func<ITranslateSpecification<TResult, TInput, TSchema>> specificationFactory)
            where TResult : TSchema
            where TInput : TSchema
        {
            ICachedTranslator translator;
            ITranslator<TInput, TSchema> inputTranslator;
            if (_translators.TryGetValue(translateSpecificationType, out translator) && translator.TryGetTranslator(out inputTranslator))
            {
                return inputTranslator;
            }

            var specification = specificationFactory();
            specification.ValidateSpecification();

            var factory = _translateFactoryProvider.GetTranslateFactory(specification);

            inputTranslator = factory.Create(this);

            _translators[translateSpecificationType] = new CachedTranslator<TInput>(inputTranslator);

            return inputTranslator;
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

        public ITranslator<T, TSchema> GetTranslator<T>(Type translateSpecificationType, Func<ITranslateFactory<T, TSchema>> translateFactory)
            where T : TSchema
        {
            ICachedTranslator translator;
            ITranslator<T, TSchema> inputTranslator;
            if (_translators.TryGetValue(translateSpecificationType, out translator) && translator.TryGetTranslator(out inputTranslator))
            {
                return inputTranslator;
            }

            var factory = translateFactory();

            inputTranslator = factory.Create(this);

            _translators[translateSpecificationType] = new CachedTranslator<T>(inputTranslator);

            return inputTranslator;
        }

        public Type GetImplementationType<T>()
        {
            return _implementationBuilder.GetImplementationType(typeof(T));
        }


        interface ICachedTranslator
        {
            bool TryGetTranslator<T>(out ITranslator<T, TSchema> translator)
                where T : TSchema;
        }


        class CachedTranslator<TInput> :
            ICachedTranslator
            where TInput : TSchema
        {
            readonly ITranslator<TInput, TSchema> _translator;

            public CachedTranslator(ITranslator<TInput, TSchema> translator)
            {
                _translator = translator;
            }

            public bool TryGetTranslator<T>(out ITranslator<T, TSchema> translator)
                where T : TSchema
            {
                translator = _translator as ITranslator<T, TSchema>;

                return translator != null;
            }
        }
    }
}