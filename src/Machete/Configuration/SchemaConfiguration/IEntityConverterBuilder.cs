namespace Machete.SchemaConfiguration
{
    using System;
    using Entities;

    public interface IEntityConverterBuilder<out TEntity, in TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        /// <summary>
        /// The implementation type for this entity
        /// </summary>
        Type ImplementationType { get; }

        /// <summary>
        /// Return an entity map for the specified entity
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <returns></returns>
        IEntityConverter<T> GetEntityMap<T>()
            where T : TSchema;

        /// <summary>
        /// Adds a property to the entity map, with the matching slice provider
        /// </summary>
        /// <param name="property"></param>
        void Add(IEntityProperty<TEntity> property);
    }
}