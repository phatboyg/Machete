namespace Machete
{
    /// <summary>
    /// A collection of entities, which can be accessed by index
    /// </summary>
    /// <typeparam name="TSchema"></typeparam>
    public interface EntityCollection<TSchema>
        where TSchema : Entity
    {
        /// <summary>
        /// Returns the entity at the specified <paramref name="index"/> if present.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="entity"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool TryGetEntity<T>(int index, out T entity)
            where T : TSchema;

        /// <summary>
        /// The schema associated with the result
        /// </summary>
        ISchema<TSchema> Schema { get; }
    }
}