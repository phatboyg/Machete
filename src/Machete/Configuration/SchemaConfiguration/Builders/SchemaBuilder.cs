namespace Machete.SchemaConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using Internals.Extensions;
    using Internals.Reflection;
    using TypeSelectors;


    public class SchemaBuilder<TSchema> :
        ISchemaBuilder<TSchema>,
        ISchemaLayoutBuilder<TSchema>
        where TSchema : Entity
    {
        readonly IDictionary<Type, IEntityConverter> _entityConverters;
        readonly IImplementationBuilder _implementationBuilder;
        readonly IEntitySelectorFactory _entitySelectorFactory;
        readonly IDictionary<Type, IEntityFormatter> _entityFormatters;
        readonly IDictionary<Type, ILayoutParserFactory> _layouts;

        public SchemaBuilder(IEntitySelectorFactory entitySelectorFactory)
        {
            _entitySelectorFactory = entitySelectorFactory;

            _entityConverters = new Dictionary<Type, IEntityConverter>();
            _entityFormatters = new Dictionary<Type, IEntityFormatter>();
            _layouts = new Dictionary<Type, ILayoutParserFactory>();

            _implementationBuilder = new DynamicImplementationBuilder();
        }

        Type ISchemaLayoutBuilder<TSchema>.GetImplementationType<T>()
        {
            return _implementationBuilder.GetImplementationType(typeof(T));
        }

        Type ISchemaBuilder<TSchema>.GetImplementationType<T>()
        {
            return _implementationBuilder.GetImplementationType(typeof(T));
        }

        public IEntityConverter<T> GetEntityConverter<T>()
            where T : TSchema
        {
            IEntityConverter result;
            if (_entityConverters.TryGetValue(typeof(T), out result))
            {
                return result as IEntityConverter<T>;
            }

            throw new KeyNotFoundException($"The {typeof(T).Name} entity converter was not found");
        }

        public IEntityFormatter<T> GetEntityFormatter<T>()
            where T : TSchema
        {
            IEntityFormatter result;
            if (_entityFormatters.TryGetValue(typeof(T), out result))
            {
                return result as IEntityFormatter<T>;
            }

            throw new KeyNotFoundException($"The {typeof(T).Name} entity formatter was not found");
        }

        public ILayoutParserFactory<T, TSchema> GetLayout<T>()
            where T : Layout
        {
            ILayoutParserFactory result;
            if (_layouts.TryGetValue(typeof(T), out result))
            {
                return result as ILayoutParserFactory<T, TSchema>;
            }

            throw new MacheteSchemaException($"The layout {TypeCache<T>.ShortName} was not found.");
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

        public void Add<T>(ILayoutParserFactory<T, TSchema> factory)
            where T : Layout
        {
            _layouts.Add(typeof(T), factory);
        }

        public ISchema<TSchema> Build()
        {
            var entityTypeSelector = _entitySelectorFactory.Build();

            return new Schema<TSchema>(_entityConverters.Values, _layouts.Values, entityTypeSelector, _implementationBuilder);
        }
    }
}