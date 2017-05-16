namespace Machete
{
    using System;


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