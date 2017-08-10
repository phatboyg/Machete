namespace Machete
{
    using System;


    public static class LayoutExtensions
    {
        /// <summary>
        /// Safely returns the <see cref="Entity{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public static Entity<TEntity> Select<TLayout, TEntity>(this Layout<TLayout> source, Func<TLayout, Entity<TEntity>> getter)
            where TLayout : Layout
            where TEntity : Entity
        {
            if (source == null)
                return Schema.Entity.Missing<TEntity>();

            return getter(source.Value) ?? Schema.Entity.Missing<TEntity>();
        }

        /// <summary>
        /// Safely returns the <see cref="Entity{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public static EntityList<TEntity> Select<TLayout, TEntity>(this Layout<TLayout> source, Func<TLayout, EntityList<TEntity>> getter)
            where TLayout : Layout
            where TEntity : Entity
        {
            if (source == null || !source.IsPresent)
                return EntityList.Missing<TEntity>();

            return getter(source.Value) ?? EntityList.Missing<TEntity>();
        }
    }
}