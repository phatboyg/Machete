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
        readonly IList<IEntityProperty<TEntity>> _properties;
        readonly IList<IEntityInitializer<TEntity>> _initializers;

        public DynamicEntityConverterBuilder(ISchemaBuilder<TSchema> schemaBuilder, IEntitySelector entitySelector)
        {
            _schemaBuilder = schemaBuilder;
            _entitySelector = entitySelector;

            ImplementationType = schemaBuilder.GetImplementationType<TEntity>();

            _properties = new List<IEntityProperty<TEntity>>();
            _initializers = new List<IEntityInitializer<TEntity>>();
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

        public void Add(IEntityInitializer<TEntity> property)
        {
            _initializers.Add(property);
        }

        public IEntityConverter<TEntity> Build()
        {
            var entityType = new SchemaEntityInfo(typeof(TEntity), typeof(TSchema), _entitySelector);

            var entityFactory = new DynamicEntityFactory<TEntity>(ImplementationType, entityType, _initializers);

            return new DynamicEntityConverter<TEntity, TSchema>(entityType, entityFactory, _properties);
        }
    }
}