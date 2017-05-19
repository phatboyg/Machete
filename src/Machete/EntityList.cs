namespace Machete
{
    /// <summary>
    /// An entity list is zero or more entities in a layout.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public interface EntityList<TEntity> :
        IEntity
        where TEntity : Entity
    {
        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        Entity<TEntity> this[int index] { get; }

        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        /// <param name="value">The output value</param>
        /// <returns>True if the value exists, otherwise false.</returns>
        bool TryGetValue(int index, out Entity<TEntity> value);
    }
}