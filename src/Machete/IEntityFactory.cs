namespace Machete
{
    using System;


    public interface IEntityFactory<out TSchema> :
        IEntityFactory
        where TSchema : Entity
    {
        /// <summary>
        /// Create an instance of the entity
        /// </summary>
        /// <returns></returns>
        TSchema Create();
    }


    public interface IEntityFactory
    {
        /// <summary>
        /// The schema type created by this factory
        /// </summary>
        Type EntityType { get; }

        /// <summary>
        /// Create an instance of the entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Create<T>()
            where T : Entity;
    }
}