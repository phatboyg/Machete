namespace Machete
{
    using System;


    public interface IEntityFormatter<in TEntity> :
        IEntityFormatter
        where TEntity : Entity
    {
        /// <summary>
        /// Format an entity
        /// </summary>
        /// <param name="entity">The entity to format</param>
        /// <returns>The text slice for the entity</returns>
        TextSlice FormatEntity(TEntity entity);
    }


    public interface IEntityFormatter
    {
        Type EntityType { get; }
    }
}