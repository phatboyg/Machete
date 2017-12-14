namespace Machete
{
    /// <summary>
    /// An entity result contains an ordered collection of entities
    /// </summary>
    /// <typeparam name="TSchema">The schema type</typeparam>
    public interface EntityResult<TSchema> :
        EntityCollection<TSchema>,
        Result
        where TSchema : Entity
    {
    }
}