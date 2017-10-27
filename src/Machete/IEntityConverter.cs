namespace Machete
{
    public interface IEntityConverter<TEntity> :
        IEntityConverter,
        IValueConverter<TEntity>
        where TEntity : Entity
    {
    }


    public interface IEntityConverter
    {
        /// <summary>
        /// The underlying entity type for this mapper
        /// </summary>
        EntityInfo EntityInfo { get; }

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