namespace Machete
{
    /// <summary>
    /// An entity result contains an ordered collection of entities
    /// </summary>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public interface EntityResult<TSchema> :
        Result
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