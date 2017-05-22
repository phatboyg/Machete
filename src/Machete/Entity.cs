namespace Machete
{
    /// <summary>
    /// An entity is any schema type, used to control the scope in which the specific entity
    /// can be used. The base TSchema type typically is used to baseline the entity type
    /// for use within a schema.
    /// </summary>
    public interface Entity
    {
        EntityType EntityType { get; }
    }


    /// <summary>
    /// In a layout, an Entity<typeparamref name="TEntity"/> is a single occurrence of the entity
    /// type.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public interface Entity<out TEntity> :
        IEntity
        where TEntity : Entity
    {
        /// <summary>
        /// The entity value
        /// </summary>
        TEntity Value { get; }
    }
}