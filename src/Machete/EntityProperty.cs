namespace Machete
{
    using System;


    public class EntityProperty<TEntity> :
        Entity<TEntity>
        where TEntity : Entity
    {
        public EntityProperty(TEntity entity)
        {
            Entity = entity;
            IsPresent = true;
            HasValue = true;
        }

        public EntityProperty()
        {
            IsPresent = false;
            HasValue = false;
        }
        
        public Type EntityType => typeof(TEntity);

        public bool IsPresent { get; }

        public bool HasValue { get; }

        public TEntity Entity { get; }
    }
}