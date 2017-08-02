namespace Machete
{
    public interface IEntityResultCollection<TSchema>
        where TSchema : Entity
    {
        void Add(EntityResult<TSchema> result);

        /// <summary>
        /// Returns the result from the collection
        /// </summary>
        /// <returns></returns>
        EntityResult<TSchema> ToResult();
    }
}