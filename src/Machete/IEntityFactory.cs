namespace Machete
{
    using System;


    /// <summary>
    /// Creates a <typeparamref name="TEntity"/> entity, and applies any initializers
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public interface IEntityFactory<out TEntity> :
        IEntityFactory
        where TEntity : Entity
    {
        /// <summary>
        /// Create an instance of the entity
        /// </summary>
        /// <returns></returns>
        TEntity Create();
    }


    public interface IEntityFactory
    {
        /// <summary>
        /// The schema type created by this factory
        /// </summary>
        Type EntityType { get; }
    }
}