namespace Machete
{
    using System;
    using System.Collections.Generic;


    public class EntityListProperty<TEntity> :
        PropertyList<TEntity, Entity<TEntity>>,
        EntityList<TEntity>
        where TEntity : Entity
    {
        public EntityListProperty(IReadOnlyList<TEntity> entities)
            : base(EntityPropertyFactory<TEntity>.Factory, entities)
        {
        }

        public Type EntityType => typeof(TEntity);
    }
}