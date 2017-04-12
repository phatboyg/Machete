namespace Machete
{
    /// <summary>
    /// Provides a <see cref="TextSlice"/> for an entity, which may be composed of multiple slices
    /// depending upon the value type and how the value is mapped.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public interface ITextSliceProvider<in TEntity>
        where TEntity : Entity
    {
        /// <summary>
        /// Returns a TextSlice for the entity
        /// </summary>
        /// <param name="entity"></param>
        TextSlice GetSlice(TEntity entity);
    }
}