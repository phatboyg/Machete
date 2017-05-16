namespace Machete
{
    using System;
    using System.Collections.Generic;


    public class EntityListProperty<TEntity> :
        EntityList<TEntity>
        where TEntity : Entity
    {
        readonly IReadOnlyList<TEntity> _entities;

        public EntityListProperty(IReadOnlyList<TEntity> entities)
        {
            _entities = entities;
            IsPresent = true;
            HasValue = true;
        }

        public Type EntityType => typeof(TEntity);

        public bool IsPresent { get; }

        public bool HasValue { get; }

        public TEntity Entity { get; }

        public Entity<TEntity> this[int index]
        {
            get
            {
                if(index < _entities.Count)
                    return new EntityProperty<TEntity>(_entities[index]);

                return new EntityProperty<TEntity>();

            }
        }

        public bool TryGetValue(int index, out Entity<TEntity> value)
        {
            if (index < _entities.Count)
            {
                value = new EntityProperty<TEntity>(_entities[index]);
                return true;
            }

            value = null;
            return false;
        }
    }
}