namespace Machete
{
    using System.Collections.Generic;


    public static class EntityListExtensions
    {
        /// <summary>
        /// Converts an EntityList into an IEnumerable<Entity<TEntity>>.
        /// </summary>
        /// <param name="entities"></param>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Entity<TEntity>> ToEnumerable<TEntity>(this EntityList<TEntity> entities)
            where TEntity : Entity
        {
            for (int i = 0;; i++)
            {
                if (!entities.TryGetValue(i, out var entity))
                    break;

                if (entity.HasValue)
                    yield return entity;
            }
        }
    }
}