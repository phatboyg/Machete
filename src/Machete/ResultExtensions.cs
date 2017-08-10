namespace Machete
{
    using System;


    public static class ResultExtensions
    {
        /// <summary>
        /// Returns the result of <paramref name="result"/>, or the <paramref name="defaultValue"/> if HasValue is false.
        /// </summary>
        /// <param name="result">The query result</param>
        /// <param name="defaultValue">The default value</param>
        /// <typeparam name="T">The value type</typeparam>
        /// <typeparam name="TCursor">The cursor type</typeparam>
        public static T ValueOrDefault<TCursor, T>(this Result<Cursor<TCursor>, T> result, T defaultValue = default(T))
        {
            return result != null && result.HasValue ? result.Value : defaultValue;
        }

        /// <summary>
        /// Returns the value of <paramref name="result"/>, or the <paramref name="defaultValue"/> if HasValue is false.
        /// </summary>
        /// <param name="result">The query result</param>
        /// <param name="defaultValue">The default value</param>
        /// <typeparam name="T">The value type</typeparam>
        /// <typeparam name="TCursor">The cursor type</typeparam>
        public static T ValueOrDefault<TCursor, T>(this Result<Cursor<TCursor>, Value<T>> result, T defaultValue = default(T))
        {
            return result != null && result.HasValue && result.Value.HasValue ? result.Value.Value : defaultValue;
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Select<TCursor, TInput, T>(this Result<Cursor<TCursor>, TInput> result, Func<TInput, Value<T>> getter)
        {
            if (result == null || !result.HasValue)
                return Value.Missing<T>();

            return getter(result.Value) ?? Value.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="ValueList{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ValueList<T> Select<TCursor, TInput, T>(this Result<Cursor<TCursor>, TInput> result, Func<TInput, ValueList<T>> getter)
        {
            if (result == null || !result.HasValue)
                return ValueList.Missing<T>();

            return getter(result.Value) ?? ValueList.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Entity{T}"/> from a layout object.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Entity<T> Select<TCursor, TLayout, T>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, Entity<T>> getter)
            where TLayout : Layout
            where T : Entity
        {
            if (result == null || !result.HasValue)
                return Schema.Entity.Missing<T>();

            return getter(result.Value) ?? Schema.Entity.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="EntityList{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static EntityList<T> Select<TCursor, TLayout, T>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, EntityList<T>> getter)
            where TLayout : Layout
            where T : Entity
        {
            if (result == null || !result.HasValue)
                return EntityList.Missing<T>();

            return getter(result.Value) ?? EntityList.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Layout{T}"/> from a layout object.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Layout<T> Select<TCursor, TLayout, T>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, Layout<T>> getter)
            where TLayout : Layout
            where T : Layout
        {
            if (result == null || !result.HasValue)
                return Schema.Layout.Missing<T>();

            return getter(result.Value) ?? Schema.Layout.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="LayoutList{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static LayoutList<T> Select<TCursor, TLayout, T>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, LayoutList<T>> getter)
            where TLayout : Layout
            where T : Layout
        {
            if (result == null || !result.HasValue)
                return LayoutList.Missing<T>();

            return getter(result.Value) ?? LayoutList.Missing<T>();
        }
    }
}