namespace Machete
{
    public interface IEntityFormatter<in TEntity, in TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        /// <summary>
        /// Format an entity
        /// </summary>
        /// <param name="entity">The entity to format</param>
        /// <param name="slice">The resulting fragment</param>
        /// <returns>True if the entity could be formatted, otherwise false</returns>
        bool TryFormatEntity(TEntity entity, out TextSlice slice);
    }
}