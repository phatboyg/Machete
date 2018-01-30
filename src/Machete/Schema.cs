namespace Machete
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using Configuration;
    using Entities;
    using Formatters;
    using Internals.Extensions;
    using Internals.Reflection;
    using Layouts;
    using TranslatorConfiguration;
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
        TranslatorFactoryContext<TSchema>
        where TSchema : Entity
    {
        readonly IDictionary<Type, IEntityConverter> _entityConverters;
        readonly IDictionary<Type, IEntityFactory> _entityFactories;
        readonly IDictionary<Type, IEntityFormatter> _entityFormatters;
        readonly IEntitySelector _entitySelector;
        readonly IEntityTranslatorFactoryProvider<TSchema> _entityTranslateFactoryProvider;
        readonly ConcurrentDictionary<Type, ICachedTranslator> _entityTranslators;
        readonly ConcurrentDictionary<Type, IEntityCreator<TSchema>> _entityCreators;
        readonly IDictionary<Type, IImplementedTypeCache> _implementedTypeCache;
        readonly Dictionary<Type, ILayoutFormatter> _layoutFormatters;
        readonly IDictionary<Type, ILayoutParserFactory> _layouts;
        readonly ITranslatorFactoryProvider<TSchema> _translateFactoryProvider;
        readonly ConcurrentDictionary<Type, ITranslator<TSchema>> _translators;

        public Schema(IEnumerable<IEntityConverter> entities, IEnumerable<IEntityFormatter> formatters, IEnumerable<ILayoutParserFactory> layouts, IEntitySelector entitySelector,
            IEntityTranslatorFactoryProvider<TSchema> entityTranslateFactoryProvider, ITranslatorFactoryProvider<TSchema> translateFactoryProvider,
            IEnumerable<ILayoutFormatter> layoutFormatters)
        {
            _entitySelector = entitySelector;
            _entityTranslateFactoryProvider = entityTranslateFactoryProvider;
            _translateFactoryProvider = translateFactoryProvider;

            IEntityConverter[] entityConverters = entities as IEntityConverter[] ?? entities.ToArray();

            _implementedTypeCache = new Dictionary<Type, IImplementedTypeCache>();
            _entityConverters = entityConverters.ToDictionary(x => x.EntityInfo.EntityType);
            _entityFactories = entityConverters.ToDictionary(x => x.EntityInfo.EntityType, x => x.Factory);
            _entityFormatters = formatters.ToDictionary(x => x.EntityType);
            _layouts = layouts.ToDictionary(x => x.LayoutType);
            _layoutFormatters = layoutFormatters.ToDictionary(x => x.LayoutType);

            _entityTranslators = new ConcurrentDictionary<Type, ICachedTranslator>();
            _entityCreators = new ConcurrentDictionary<Type, IEntityCreator<TSchema>>();
            _translators = new ConcurrentDictionary<Type, ITranslator<TSchema>>();
        }

        public bool TryConvertEntity<T>(TextSlice slice, out T entity)
            where T : TSchema
        {
            if (_entitySelector.SelectEntity(slice, out var entityInfo))
            {
                if (_entityConverters.TryGetValue(entityInfo.EntityType, out var entityConverter))
                {
                    entity = entityConverter.Convert<T>(slice);
                    return true;
                }
            }
            
            entity = default;
            return false;
        }

        public bool TryGetEntityFormatter<T>(out IEntityFormatter<T> entityFormatter)
            where T : TSchema
        {
            lock (_entityFormatters)
            {
                if (_entityFormatters.TryGetValue(typeof(T), out var formatter))
                {
                    entityFormatter = formatter as IEntityFormatter<T>;
                    return entityFormatter != null;
                }
            }

            entityFormatter = null;
            return false;
        }

        public bool TryGetEntityFormatter(TSchema entity, out IEntityFormatter entityFormatter)
        {
            var entityType = entity.GetType();

            lock (_entityFormatters)
            {
                if (_entityFormatters.TryGetValue(entityType, out entityFormatter))
                    return true;
            }

            if (!_implementedTypeCache.TryGetValue(entityType, out var typeCache))
            {
                typeCache = (IImplementedTypeCache) Activator.CreateInstance(typeof(ImplementedTypeCache<>).MakeGenericType(entityType));
                _implementedTypeCache[entityType] = typeCache;
            }

            EntityFormatScanner scanner;
            lock (_entityFormatters)
            {
                scanner = new EntityFormatScanner(_entityFormatters);
            }

            typeCache.EnumerateImplementedTypes(scanner, true);

            if (scanner.Formatter != null)
            {
                entityFormatter = scanner.Formatter;

                // save this for later, so we don't have to look it up again
                lock (_entityFormatters)
                {
                    _entityFormatters[entityType] = entityFormatter;
                }

                return true;
            }

            entityFormatter = null;
            return false;
        }

        public bool TryGetLayout<T>(out ILayoutParserFactory<T, TSchema> result)
            where T : Layout
        {
            if (_layouts.TryGetValue(typeof(T), out var layoutParserFactory))
            {
                result = layoutParserFactory as ILayoutParserFactory<T, TSchema>;
                return result != null;
            }

            result = null;
            return false;
        }

        public IEntityTranslator<TInput, TSchema> GetEntityTranslator<TResult, TInput, TTranslation>()
            where TResult : TSchema
            where TInput : TSchema
            where TTranslation : IEntityTranslatorSpecification<TResult, TInput, TSchema>, new()
        {
            ICachedTranslator translator = _entityTranslators.GetOrAdd(typeof(TTranslation), _ =>
            {
                var specification = new TTranslation();

                specification.ValidateSpecification();

                var factory = _entityTranslateFactoryProvider.GetTranslatorFactory(specification);

                return new CachedTranslator<TInput>(factory.Create(this));
            });

            if (translator.TryGetTranslator(out IEntityTranslator<TInput, TSchema> inputTranslator))
                return inputTranslator;

            throw new MacheteSchemaException(
                $"The translator does not support the entity type specified: {TypeCache<TTranslation>.ShortName} ({TypeCache<TResult>.ShortName})");
        }

        public IEntityTranslator<TInput, TSchema> CreateEntityTranslator<TResult, TInput>(IEntityTranslatorSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return _entityTranslateFactoryProvider.GetTranslatorFactory(specification).Create(this);
        }

        public IEntityCreator<TSchema> GetEntityCreator<TResult, TDescription>()
            where TResult : TSchema
            where TDescription : IEntityCreatorSpecification<TResult, TSchema>, new()
        {
            return _entityCreators.GetOrAdd(typeof(TDescription), _ =>
            {
                var specification = new TDescription();

                specification.ValidateSpecification();

                var factory = _entityTranslateFactoryProvider.GetCreatorFactory(specification);

                return factory.Create(this);
            });
        }

        public IEntityCreator<TSchema> CreateEntityCreator<TResult>(IEntityCreatorSpecification<TResult, TSchema> specification)
            where TResult : TSchema
        {
            return _entityTranslateFactoryProvider.GetCreatorFactory(specification).Create(this);
        }

        public ITranslator<TSchema> GetTranslator(Type translationType)
        {
            return _translators.GetOrAdd(translationType, _ =>
            {
                var specification = (ITranslatorSpecification<TSchema>) Activator.CreateInstance(translationType);
                specification.ValidateSpecification();

                var factory = _translateFactoryProvider.GetTranslatorFactory(specification);

                return factory.Create(this);
            });
        }

        public ITranslator<TSchema> GetTranslator<T>()
            where T : ITranslatorSpecification<TSchema>, new()
        {
            return _translators.GetOrAdd(typeof(T), _ =>
            {
                var specification = new T();
                specification.ValidateSpecification();

                var factory = _translateFactoryProvider.GetTranslatorFactory(specification);

                return factory.Create(this);
            });
        }

        public bool TryGetEntityFactory<T>(out IEntityFactory<T> entityFactory)
            where T : TSchema
        {
            if (_entityFactories.TryGetValue(typeof(T), out var factory))
            {
                entityFactory = factory as IEntityFactory<T>;
                return entityFactory != null;
            }

            // TODO create if possible
            entityFactory = null;
            return false;
        }

        public bool TryGetLayoutFormatter<T>(out ILayoutFormatter<T> formatter)
            where T : Layout
        {
            lock (_layoutFormatters)
            {
                if (_layoutFormatters.TryGetValue(typeof(T), out ILayoutFormatter layoutFormatter))
                {
                    formatter = layoutFormatter as ILayoutFormatter<T>;
                    return formatter != null;
                }
            }

            formatter = null;
            return false;
        }

        public bool TryGetLayoutFormatter<TLayout>(TLayout layout, out ILayoutFormatter formatter)
            where TLayout : Layout
        {
            var layoutType = layout.GetType();

            lock (_layoutFormatters)
            {
                if (_layoutFormatters.TryGetValue(layoutType, out formatter))
                    return true;
            }

            if (!_implementedTypeCache.TryGetValue(layoutType, out IImplementedTypeCache typeCache))
            {
                typeCache = (IImplementedTypeCache) Activator.CreateInstance(typeof(ImplementedTypeCache<>).MakeGenericType(layoutType));
                _implementedTypeCache[layoutType] = typeCache;
            }

            var scanner = new LayoutFormatScanner(_layoutFormatters);

            typeCache.EnumerateImplementedTypes(scanner, true);

            if (scanner.Formatter != null)
            {
                formatter = scanner.Formatter;

                // save this for later, so we don't have to look it up again
                lock (_layoutFormatters)
                {
                    _layoutFormatters[layoutType] = formatter;
                }

                return true;
            }

            formatter = null;
            return false;
        }


        class LayoutFormatScanner :
            IImplementedType
        {
            readonly IDictionary<Type, ILayoutFormatter> _formatters;

            public LayoutFormatScanner(IDictionary<Type, ILayoutFormatter> formatters)
            {
                _formatters = formatters ?? throw new ArgumentNullException(nameof(formatters));
            }

            public ILayoutFormatter Formatter { get; private set; }

            public void ImplementsType<T>(bool direct)
                where T : class
            {
                if (Formatter != null)
                    return;

                lock (_formatters)
                {
                    if (_formatters.TryGetValue(typeof(T), out ILayoutFormatter formatter))
                        Formatter = formatter;
                }
            }
        }


        class EntityFormatScanner :
            IImplementedType
        {
            readonly IDictionary<Type, IEntityFormatter> _formatters;

            public EntityFormatScanner(IDictionary<Type, IEntityFormatter> formatters)
            {
                _formatters = new Dictionary<Type, IEntityFormatter>(formatters);
            }

            public IEntityFormatter Formatter { get; private set; }

            public void ImplementsType<T>(bool direct)
                where T : class
            {
                if (Formatter != null)
                    return;

                lock (_formatters)
                {
                    if (_formatters.TryGetValue(typeof(T), out var formatter))
                        Formatter = formatter;
                }
            }
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