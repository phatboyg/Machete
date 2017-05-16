namespace Machete
{
    public interface IFormat<in TSchema>
    {
        /// <summary>
        /// Format an entity
        /// </summary>
        /// <param name="entity">The entity to format</param>
        /// <param name="slice">The resulting fragment</param>
        /// <typeparam name="T">The entity type</typeparam>
        /// <returns>True if the entity could be formatted, otherwise false</returns>
        bool TryFormatEntity<T>(T entity, out TextSlice slice);
    }
}