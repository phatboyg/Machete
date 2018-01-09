namespace Machete.SchemaConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using Formatters;
    using Internals.Extensions;
    using Translators;
    using Translators.FactoryProviders;
    using TypeSelectors;


    public class SchemaBuilder<TSchema> :
        ISchemaBuilder<TSchema>,
        ISchemaLayoutBuilder<TSchema>
        where TSchema : Entity
    {
        readonly IDictionary<Type, IEntityConverter> _entityConverters;
        readonly IDictionary<Type, IEntityFormatter> _entityFormatters;
        readonly IEntitySelectorFactory _entitySelectorFactory;
        readonly Dictionary<Type, ILayoutFormatter> _layoutFormatters;
        readonly IDictionary<Type, ILayoutParserFactory> _layouts;
        readonly ITranslatorFactoryProvider<TSchema> _translateFactoryProvider;
        IEntityTranslatorFactoryProvider<TSchema> _entityTranslateFactoryProvider;

        public SchemaBuilder(IEntitySelectorFactory entitySelectorFactory)
        {
            _entitySelectorFactory = entitySelectorFactory ?? throw new ArgumentNullException(nameof(entitySelectorFactory));

            _entityConverters = new Dictionary<Type, IEntityConverter>();
            _entityFormatters = new Dictionary<Type, IEntityFormatter>();
            _layouts = new Dictionary<Type, ILayoutParserFactory>();
            _layoutFormatters = new Dictionary<Type, ILayoutFormatter>();

            _entityTranslateFactoryProvider = new SchemaEntityTranslatorFactoryProvider<TSchema>();
            _translateFactoryProvider = new SchemaTranslatorFactoryProvider<TSchema>();
        }

        public IEntityConverter<T> GetEntityConverter<T>()
            where T : TSchema
        {
            if (_entityConverters.TryGetValue(typeof(T), out var result))
                return result as IEntityConverter<T>;

            throw new KeyNotFoundException($"The {typeof(T).Name} entity converter was not found");
        }

        public IEntityFormatter<T> GetEntityFormatter<T>()
            where T : TSchema
        {
            if (_entityFormatters.TryGetValue(typeof(T), out var result))
                return result as IEntityFormatter<T>;

            throw new KeyNotFoundException($"The {typeof(T).Name} entity formatter was not found");
        }

        public void Add<T>(IEntityConverter<T> converter)
            where T : TSchema
        {
            _entityConverters[converter.EntityInfo.EntityType] = converter;

            if (converter.EntityInfo.EntitySelector != null)
                _entitySelectorFactory.Add(converter.EntityInfo);
        }

        public void Add<T>(IEntityFormatter<T> formatter)
            where T : TSchema
        {
            _entityFormatters[formatter.EntityType] = formatter;
        }

        public void Add<T>(ILayoutFormatter<T> formatter)
            where T : Layout
        {
            _layoutFormatters[formatter.LayoutType] = formatter;
        }

        public ILayoutParserFactory<T, TSchema> GetLayout<T>()
            where T : Layout
        {
            if (_layouts.TryGetValue(typeof(T), out var result))
                return result as ILayoutParserFactory<T, TSchema>;

            throw new MacheteSchemaException($"The layout {TypeCache<T>.ShortName} was not found.");
        }

        public void SetTranslateFactoryProvider(IEntityTranslatorFactoryProvider<TSchema> entityTranslateFactoryProvider)
        {
            _entityTranslateFactoryProvider = entityTranslateFactoryProvider;
        }

        public void Add<T>(ILayoutParserFactory<T, TSchema> factory)
            where T : Layout
        {
            _layouts[factory.LayoutType] = factory;
        }

        public ISchema<TSchema> Build()
        {
            var entityTypeSelector = _entitySelectorFactory.Build();

            return new Schema<TSchema>(_entityConverters.Values, _entityFormatters.Values, _layouts.Values, entityTypeSelector,
                _entityTranslateFactoryProvider, _translateFactoryProvider, _layoutFormatters.Values);
        }
    }
}