namespace Machete
{
    /// <summary>
    /// An entity result is a list of entities which were parsed from the input
    /// </summary>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public interface EntityResult<TSchema>
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