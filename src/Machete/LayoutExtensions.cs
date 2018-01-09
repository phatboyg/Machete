namespace Machete
{
    using System;
    using System.Diagnostics;


    public static class LayoutExtensions
    {
        /// <summary>
        /// Safely returns the <see cref="Entity{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Entity<T> Select<TLayout, T>(this Layout<TLayout> source, Func<TLayout, Entity<T>> projector)
            where TLayout : Layout
            where T : Entity
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return Schema.Entity.Missing<T>();

            return projector(source.Value) ?? Schema.Entity.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Entity{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static EntityList<T> Select<TLayout, T>(this Layout<TLayout> source, Func<TLayout, EntityList<T>> projector)
            where TLayout : Layout
            where T : Entity
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return EntityList.Missing<T>();

            return projector(source.Value) ?? EntityList.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Layout{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Layout<T> Select<TLayout, T>(this Layout<TLayout> source, Func<TLayout, Layout<T>> projector)
            where TLayout : Layout
            where T : Layout
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return Schema.Layout.Missing<T>();

            return projector(source.Value) ?? Schema.Layout.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Layout{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static LayoutList<T> Select<TLayout, T>(this Layout<TLayout> source, Func<TLayout, LayoutList<T>> projector)
            where TLayout : Layout
            where T : Layout
        {
            Debug.Assert(source != null);

            if (source == null || !source.HasValue)
                return LayoutList.Missing<T>();

            return projector(source.Value) ?? LayoutList.Missing<T>();
        }
    }
}