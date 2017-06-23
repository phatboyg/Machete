namespace Machete.SchemaConfiguration
{
    public interface IEntityFormatterBuilder<out TEntity, in TSchema>
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
        /// <param name="sliceProvider"></param>
        void Add(ITextSliceProvider<TEntity> sliceProvider);
    }
}