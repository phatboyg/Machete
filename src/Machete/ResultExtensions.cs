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
        public static T ValueOrDefault<TCursor, T>(this Result<Cursor<TCursor>, T> result, T defaultValue = default)
        {
            return result != null && result.HasResult ? result.Result : defaultValue;
        }

        /// <summary>
        /// Returns the value of <paramref name="result"/>, or the <paramref name="defaultValue"/> if HasValue is false.
        /// </summary>
        /// <param name="result">The query result</param>
        /// <param name="defaultValue">The default value</param>
        /// <typeparam name="T">The value type</typeparam>
        /// <typeparam name="TCursor">The cursor type</typeparam>
        public static T ValueOrDefault<TCursor, T>(this Result<Cursor<TCursor>, Value<T>> result, T defaultValue = default)
        {
            return result != null && result.HasResult && result.Result.HasValue ? result.Result.Value : defaultValue;
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Select<TCursor, TInput, T>(this Result<Cursor<TCursor>, TInput> result, Func<TInput, Value<T>> projector)
        {
            if (result == null || !result.HasResult)
                return Value.Missing<T>();

            return projector(result.Result) ?? Value.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="ValueList{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ValueList<T> Select<TCursor, TInput, T>(this Result<Cursor<TCursor>, TInput> result, Func<TInput, ValueList<T>> projector)
        {
            if (result == null || !result.HasResult)
                return ValueList.Missing<T>();

            return projector(result.Result) ?? ValueList.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Entity{T}"/> from a layout object.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Entity<T> Select<TCursor, TLayout, T>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, Entity<T>> projector)
            where TLayout : Layout
            where T : Entity
        {
            if (result == null || !result.HasResult)
                return Schema.Entity.Missing<T>();

            return projector(result.Result) ?? Schema.Entity.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="EntityList{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static EntityList<T> Select<TCursor, TLayout, T>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, EntityList<T>> projector)
            where TLayout : Layout
            where T : Entity
        {
            if (result == null || !result.HasResult)
                return EntityList.Missing<T>();

            return projector(result.Result) ?? EntityList.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Layout{T}"/> from a layout object.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Layout<T> Select<TCursor, TLayout, T>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, Layout<T>> projector)
            where TLayout : Layout
            where T : Layout
        {
            if (result == null || !result.HasResult)
                return Schema.Layout.Missing<T>();

            return projector(result.Result) ?? Schema.Layout.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="LayoutList{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TLayout"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static LayoutList<T> Select<TCursor, TLayout, T>(this Result<Cursor<TCursor>, TLayout> result, Func<TLayout, LayoutList<T>> projector)
            where TLayout : Layout
            where T : Layout
        {
            if (result == null || !result.HasResult)
                return LayoutList.Missing<T>();

            return projector(result.Result) ?? LayoutList.Missing<T>();
        }

        public static Result<Cursor<TInput>, TResult> Select<TInput, T, TResult>(this Result<Cursor<TInput>, T> result, Func<T, TResult> projector)
        {
            if (result.HasResult)
                return new Success<Cursor<TInput>, TResult>(projector(result.Result), result.Next);

            return new Unmatched<Cursor<TInput>, TResult>(result.Next);
        }
        
        public static Result<Cursor<TInput>, TResult> Select<TInput, T, TResult>(this Result<Cursor<TInput>, T> result, Func<Cursor<TInput>, T, Result<Cursor<TInput>, TResult>> projector)
        {
            if (result.HasResult)
                return projector(result.Next, result.Result);

            return new Unmatched<Cursor<TInput>, TResult>(result.Next);
        }

        public static Result<TextSpan, TResult> Select<T, TResult>(this Result<TextSpan, T> result, Func<T, TResult> projector)
        {
            if (result.HasResult)
                return new Success<TextSpan, TResult>(projector(result.Result), result.Next);

            return new Unmatched<TextSpan, TResult>(result.Next);
        }
        
        public static Result<TextSpan, TResult> Select<T, TResult>(this Result<TextSpan, T> result, Func<TextSpan, T, Result<TextSpan, TResult>> projector)
        {
            if (result.HasResult)
                return projector(result.Next, result.Result);

            return new Unmatched<TextSpan, TResult>(result.Next);
        }
        
        public static Result<Cursor<TInput>, TResult> Where<TInput, TResult>(this Result<Cursor<TInput>, TResult> result, Func<TResult, bool> filter)
        {
            if (result.HasResult && filter(result.Result))
                return result;

            return new Unmatched<Cursor<TInput>, TResult>(result.Next);
        }
        
        public static Result<TextSpan, TResult> Where<TResult>(this Result<TextSpan, TResult> result, Func<TResult, bool> filter)
        {
            if (result.HasResult && filter(result.Result))
                return result;

            return new Unmatched<TextSpan, TResult>(result.Next);
        }
    }
}