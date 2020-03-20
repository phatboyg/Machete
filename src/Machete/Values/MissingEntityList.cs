namespace Machete.Values
{
    using System;


    /// <summary>
    /// A missing value array is used when the source fragment is missing.
    /// </summary>
    /// <typeparam name="TEntity">The value type</typeparam>
    public class MissingEntityList<TEntity> :
        EntityList<TEntity>
        where TEntity : Entity
    {
        Type IEntity.EntityType => typeof(TEntity);
        bool IEntity.HasValue => false;

        public Entity<TEntity> this[int index] => throw new ValueMissingException("The entity is missing.");

        bool EntityList<TEntity>.TryGetValue(int index, out Entity<TEntity> value)
        {
            throw new ValueMissingException("The entity is missing.");
        }
    }
}