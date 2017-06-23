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
        readonly IEntityTypeSelector _entityTypeSelector;
        readonly IList<IEntityProperty<TEntity>> _properties;

        public DynamicEntityConverterBuilder(ISchemaBuilder<TSchema> schemaBuilder, IEntityTypeSelector entityTypeSelector)
        {
            _schemaBuilder = schemaBuilder;
            _entityTypeSelector = entityTypeSelector;

            ImplementationType = schemaBuilder.GetImplementationType<TEntity>();

            _properties = new List<IEntityProperty<TEntity>>();
        }

        public Type ImplementationType { get; }

        public IEntityConverter<T> GetEntityConverter<T>()
            where T : TSchema
        {
            return _schemaBuilder.GetEntityConverter<T>();
        }

        public void Add(IEntityProperty<TEntity> property)
        {
            _properties.Add(property);
        }

        public IEntityConverter<TEntity> Build()
        {
            var entityType = new SchemaEntityType(typeof(TEntity), typeof(TSchema), _entityTypeSelector);

            var entityFactory = new DynamicEntityFactory<TEntity>(ImplementationType, entityType);

            return new DynamicEntityConverter<TEntity, TSchema>(entityType, entityFactory, _properties);
        }
    }
}