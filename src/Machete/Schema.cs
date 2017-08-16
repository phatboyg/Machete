namespace Machete
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;
    using Entities;
    using Internals.Extensions;
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
        readonly IDictionary<Type, IImplementedTypeCache> _implementedTypeCache;
        readonly IDictionary<Type, IEntityConverter> _entityConverters;
        readonly IDictionary<Type, IEntityFactory> _entityFactories;
        readonly IDictionary<Type, IEntityFormatter> _entityFormatters;
        readonly IDictionary<Type, ILayoutParserFactory> _layouts;
        readonly ConcurrentDictionary<Type, ICachedTranslator> _entityTranslators;
        readonly ConcurrentDictionary<Type, ITranslator<TSchema>> _translators;
        readonly IEntitySelector _entitySelector;
        readonly IImplementationBuilder _implementationBuilder;
        readonly IEntityTranslateFactoryProvider<TSchema> _entityTranslateFactoryProvider;
        readonly ITranslateFactoryProvider<TSchema> _translateFactoryProvider;

        public Schema(IEnumerable<IEntityConverter> entities, IEnumerable<IEntityFormatter> formatters, IEnumerable<ILayoutParserFactory> layouts, IEntitySelector entitySelector,
            IImplementationBuilder implementationBuilder, IEntityTranslateFactoryProvider<TSchema> entityTranslateFactoryProvider,
            ITranslateFactoryProvider<TSchema> translateFactoryProvider)
        {
            _entitySelector = entitySelector;
            _implementationBuilder = implementationBuilder;
            _entityTranslateFactoryProvider = entityTranslateFactoryProvider;
            _translateFactoryProvider = translateFactoryProvider;

            IEntityConverter[] entityConverters = entities as IEntityConverter[] ?? entities.ToArray();

            _implementedTypeCache = new Dictionary<Type, IImplementedTypeCache>();
            _entityConverters = entityConverters.ToDictionary(x => x.EntityInfo.EntityType);
            _entityFactories = entityConverters.ToDictionary(x => x.EntityInfo.EntityType, x => x.Factory);
            _entityFormatters = formatters.ToDictionary(x => x.EntityType);
            _layouts = layouts.ToDictionary(x => x.LayoutType);

            _entityTranslators = new ConcurrentDictionary<Type, ICachedTranslator>();
            _translators = new ConcurrentDictionary<Type, ITranslator<TSchema>>();
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

        public bool TryGetEntityFormatter<T>(out IEntityFormatter<T> entityFormatter)
            where T : TSchema
        {
            IEntityFormatter formatter;
            lock (_entityFormatters)
                if (_entityFormatters.TryGetValue(typeof(T), out formatter))
                {
                    entityFormatter = formatter as IEntityFormatter<T>;
                    return entityFormatter != null;
                }

            entityFormatter = null;
            return false;
        }

        public bool TryGetEntityFormatter(TSchema entity, out IEntityFormatter entityFormatter)
        {
            var entityType = entity.GetType();

            lock (_entityFormatters)
                if (_entityFormatters.TryGetValue(entityType, out entityFormatter))
                    return true;

            IImplementedTypeCache typeCache;
            if (!_implementedTypeCache.TryGetValue(entityType, out typeCache))
            {
                typeCache = (IImplementedTypeCache) Activator.CreateInstance(typeof(ImplementedTypeCache<>).MakeGenericType(entityType));
                _implementedTypeCache[entityType] = typeCache;
            }

            var scanner = new FormatScanner(_entityFormatters);

            typeCache.EnumerateImplementedTypes(scanner, true);

            if (scanner.Formatter != null)
            {
                entityFormatter = scanner.Formatter;

                // save this for later, so we don't have to look it up again
                lock (_entityFormatters)
                    _entityFormatters[entityType] = entityFormatter;
                return true;
            }

            entityFormatter = null;
            return false;
        }


        class FormatScanner :
            IImplementedType
        {
            readonly IDictionary<Type, IEntityFormatter> _entityFormatters;

            public FormatScanner(IDictionary<Type, IEntityFormatter> entityFormatters)
            {
                _entityFormatters = entityFormatters;
            }

            public IEntityFormatter Formatter { get; private set; }

            public void ImplementsType<T>(bool direct)
                where T : class
            {
                if (Formatter != null)
                    return;

                IEntityFormatter formatter;
                lock (_entityFormatters)
                    if (_entityFormatters.TryGetValue(typeof(T), out formatter))
                    {
                        Formatter = formatter;
                    }
            }
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

        public IEntityTranslator<TInput, TSchema> GetEntityTranslator<TResult, TInput>(Type translateSpecificationType,
            Func<IEntityTranslateSpecification<TResult, TInput, TSchema>> specificationFactory)
            where TResult : TSchema
            where TInput : TSchema
        {
            ICachedTranslator translator = _entityTranslators.GetOrAdd(translateSpecificationType, _ =>
            {
                var specification = specificationFactory();
                specification.ValidateSpecification();

                var factory = _entityTranslateFactoryProvider.GetTranslateFactory(specification);

                return new CachedTranslator<TInput>(factory.Create(this));
            });

            IEntityTranslator<TInput, TSchema> inputTranslator;
            if (translator.TryGetTranslator(out inputTranslator))
            {
                return inputTranslator;
            }

            throw new MacheteSchemaException(
                $"The translator does not support the entity type specified: {TypeCache.GetShortName(translateSpecificationType)} ({TypeCache<TResult>.ShortName})");
        }

        public ITranslator<TSchema> CreateTranslator(Type translateSpecificationType, Func<ITranslateSpecification<TSchema>> specificationFactory)
        {
            return _translators.GetOrAdd(translateSpecificationType, _ =>
            {
                var specification = specificationFactory();
                specification.ValidateSpecification();

                var factory = _translateFactoryProvider.GetTranslateFactory(specification);

                return factory.Create(this);
            });
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


        interface ICachedTranslator
        {
            bool TryGetTranslator<T>(out IEntityTranslator<T, TSchema> translator)
                where T : TSchema;
        }


        class CachedTranslator<TInput> :
            ICachedTranslator
            where TInput : TSchema
        {
            readonly IEntityTranslator<TInput, TSchema> _translator;

            public CachedTranslator(IEntityTranslator<TInput, TSchema> translator)
            {
                _translator = translator;
            }

            public bool TryGetTranslator<T>(out IEntityTranslator<T, TSchema> translator)
                where T : TSchema
            {
                translator = _translator as IEntityTranslator<T, TSchema>;

                return translator != null;
            }
        }
    }
}