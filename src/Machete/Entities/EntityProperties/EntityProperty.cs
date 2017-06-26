namespace Machete.Entities.EntityProperties
{
    using System;


    public class EntityProperty<TEntity> :
        Entity<TEntity>
        where TEntity : Entity
    {
        public EntityProperty(TEntity entity)
        {
            Value = entity;
            IsPresent = entity != null;
            HasValue = entity != null;
        }

        public EntityProperty()
        {
            IsPresent = false;
            HasValue = false;
        }
        
        public Type EntityType => typeof(TEntity);

        public bool IsPresent { get; }

        public bool HasValue { get; }

        public TEntity Value { get; }
    }
}