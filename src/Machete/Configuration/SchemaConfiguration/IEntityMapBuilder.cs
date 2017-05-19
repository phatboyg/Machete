namespace Machete.SchemaConfiguration
{
    using System;


    public interface IEntityMapBuilder<out TEntity, in TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        /// <summary>
        /// The implementation type for this entity
        /// </summary>
        Type ImplementationType { get; }

        /// <summary>
        /// Return a content map for the specified entity
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <returns></returns>
        IEntityMap<T> GetEntityMap<T>()
            where T : TSchema;

        /// <summary>
        /// Adds a value mapper to the content map, with the matching fragment provider
        /// </summary>
        /// <param name="property"></param>
        /// <param name="sliceProvider"></param>
        void AddValue(IEntityProperty<TEntity> property, ITextSliceProvider<TEntity> sliceProvider);
    }
}