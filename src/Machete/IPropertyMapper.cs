namespace Machete
{
    public interface IPropertyMapper<in TEntity>
        where TEntity : Entity
    {
        /// <summary>
        /// Map the data from the fragment to the entity
        /// </summary>
        /// <param name="entity">The entity instance</param>
        /// <param name="slice">The text fragment</param>
        void Map(TEntity entity, TextSlice slice);
    }
}