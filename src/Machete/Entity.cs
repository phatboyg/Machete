namespace Machete
{
    /// <summary>
    /// An entity is any schema type, used to control the scope in which the specific entity
    /// can be used. The base TSchema type typically is used to baseline the entity type
    /// for use within a schema.
    /// </summary>
    public interface Entity
    {
    }


    /// <summary>
    /// In a template, an Entity<typeparamref name="TEntity"/> is an element which
    /// can be part of a query.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public interface Entity<out TEntity> :
        IEntity
        where TEntity : Entity
    {
        TEntity Entity { get; }
    }
}