namespace Machete.SchemaConfiguration
{
    using Builders;


    public interface IEntityFormatterBuilder<TEntity, in TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        /// <summary>
        /// Return an entity map for the specified entity
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <returns></returns>
        IEntityFormatter<T> GetEntityFormatter<T>()
            where T : TSchema;

        /// <summary>
        /// Adds a property to the entity map, with the matching slice provider
        /// </summary>
        /// <param name="position">The position for the formatter</param>
        /// <param name="formatter"></param>
        void Add(int position, IEntityPropertyFormatter<TEntity> formatter);

        /// <summary>
        /// The entity formatter factory, used to build the entity formatter
        /// </summary>
        EntityFormatterFactory<TEntity> Factory { set; }
    }
}