namespace Machete.SchemaConfiguration
{
    using Entities;


    public interface IEntityConverterBuilder<out TEntity, in TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        /// <summary>
        /// Return an entity map for the specified entity
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <returns></returns>
        IEntityConverter<T> GetEntityConverter<T>()
            where T : TSchema;

        /// <summary>
        /// Adds a property to the entity map, with the matching slice provider
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="propertyValueInfo"></param>
        /// <param name="propertyConverter"></param>
        void Add(string propertyName, ValueInfo propertyValueInfo, IEntityPropertyConverter<TEntity> propertyConverter);

        /// <summary>
        /// Adds an initializer to the entity map
        /// </summary>
        /// <param name="property"></param>
        void Add(IEntityInitializer<TEntity> property);
    }
}