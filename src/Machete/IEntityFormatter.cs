namespace Machete
{
    using System;


    public interface IEntityFormatter<in TEntity> :
        IEntityFormatter
        where TEntity : Entity
    {
        /// <summary>
        /// Format an entity
        /// </summary>
        /// <param name="context"></param>
        /// <param name="entity"></param>
        void Format(FormatContext context, TEntity entity);
    }


    public interface IEntityFormatter
    {
        Type EntityType { get; }

        /// <summary>
        /// Format the entity, of which the type is dynamically assigned
        /// </summary>
        /// <param name="context"></param>
        /// <param name="entity"></param>
        /// <typeparam name="T"></typeparam>
        void Format<T>(FormatContext context, T entity)
            where T : Entity;
    }
}