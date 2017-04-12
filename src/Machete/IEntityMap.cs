namespace Machete
{
    using System;


    public interface IEntityMap<TEntity> :
        IEntityMap
        where TEntity : Entity
    {
        /// <summary>
        /// Return the entity from the text fragment
        /// </summary>
        /// <param name="slice"></param>
        /// <returns></returns>
        TEntity GetEntity(TextSlice slice);

        /// <summary>
        /// Return the fragment for the entity
        /// </summary>
        /// <param name="entity">The entity</param>
        /// <returns></returns>
        TextSlice GetSlice(TEntity entity);
    }


    public interface IEntityMap
    {
        /// <summary>
        /// The underlying entity type for this mapper
        /// </summary>
        EntityType EntityType { get; }

        /// <summary>
        /// The dynamic implementation type for this mapper
        /// </summary>
        Type ImplementationType { get; }

        /// <summary>
        /// The entity factory
        /// </summary>
        IEntityFactory Factory { get; }

        /// <summary>
        /// Return the entity from the text fragment
        /// </summary>
        /// <param name="slice"></param>
        /// <returns></returns>
        T GetEntity<T>(TextSlice slice)
            where T : Entity;
    }
}