namespace Machete.SchemaConfiguration.Builders
{
    using System;
    using System.Collections.Generic;
    using Entities;


    public class DynamicEntityConverterBuilder<TEntity, TSchema> :
        IEntityConverterBuilder<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly ISchemaBuilder<TSchema> _schemaBuilder;
        readonly IEntitySelector _entitySelector;
        readonly IList<IEntityPropertyConverter<TEntity>> _properties;
        readonly IList<IEntityInitializer<TEntity>> _initializers;
        readonly IDictionary<string, ValueInfo> _valueInfos;

        public DynamicEntityConverterBuilder(ISchemaBuilder<TSchema> schemaBuilder, IEntitySelector entitySelector)
        {
            _schemaBuilder = schemaBuilder;
            _entitySelector = entitySelector;

            ImplementationType = schemaBuilder.GetImplementationType<TEntity>();

            _properties = new List<IEntityPropertyConverter<TEntity>>();
            _initializers = new List<IEntityInitializer<TEntity>>();
            _valueInfos = new Dictionary<string, ValueInfo>(StringComparer.OrdinalIgnoreCase);
        }

        public Type ImplementationType { get; }

        public IEntityConverter<T> GetEntityConverter<T>()
            where T : TSchema
        {
            return _schemaBuilder.GetEntityConverter<T>();
        }

        public void Add(string propertyName, ValueInfo propertyValueInfo, IEntityPropertyConverter<TEntity> propertyConverter)
        {
            _properties.Add(propertyConverter);

            _valueInfos[propertyName] = propertyValueInfo;
        }

        public void Add(IEntityInitializer<TEntity> property)
        {
            _initializers.Add(property);
        }

        public IEntityConverter<TEntity> Build()
        {
            var entityType = new SchemaEntityInfo(typeof(TEntity), typeof(TSchema), _entitySelector, _valueInfos);

            var entityFactoryType = typeof(DynamicEntityFactory<,>).MakeGenericType(typeof(TEntity), ImplementationType);
            var entityFactory = (IEntityFactory<TEntity>) Activator.CreateInstance(entityFactoryType, entityType, _initializers);

            return new DynamicEntityConverter<TEntity, TSchema>(entityType, entityFactory, _properties);
        }
    }
}