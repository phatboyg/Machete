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
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Entity<T> Select<TLayout, T>(this Layout<TLayout> source, Func<TLayout, Entity<T>> getter)
            where TLayout : Layout
            where T : Entity
        {
            if (source == null)
                return Schema.Entity.Missing<T>();

            return getter(source.Value) ?? Schema.Entity.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Entity{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static EntityList<T> Select<TLayout, T>(this Layout<TLayout> source, Func<TLayout, EntityList<T>> getter)
            where TLayout : Layout
            where T : Entity
        {
            if (source == null || !source.IsPresent)
                return EntityList.Missing<T>();

            return getter(source.Value) ?? EntityList.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Layout{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Layout<T> Select<TLayout, T>(this Layout<TLayout> source, Func<TLayout, Layout<T>> getter)
            where TLayout : Layout
            where T : Layout
        {
            if (source == null)
                return Schema.Layout.Missing<T>();

            return getter(source.Value) ?? Schema.Layout.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Layout{T}"/> from a layout object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static LayoutList<T> Select<TLayout, T>(this Layout<TLayout> source, Func<TLayout, LayoutList<T>> getter)
            where TLayout : Layout
            where T : Layout
        {
            if (source == null || !source.IsPresent)
                return LayoutList.Missing<T>();

            return getter(source.Value) ?? LayoutList.Missing<T>();
        }
    }
}