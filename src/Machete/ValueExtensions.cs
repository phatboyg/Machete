namespace Machete
{
    using System;
    using System.Threading.Tasks;


    public static class ValueExtensions
    {
        /// <summary>
        /// Returns true if <see cref="IValue.HasValue"/> is true and the <see cref="Value{TValue}.Value"/> equals <paramref name="expected"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expected"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsEqualTo<T>(this Value<T> value, T expected)
        {
            return value.HasValue && value.Value.Equals(expected);
        }

        /// <summary>
        /// Returns the value of <paramref name="value"/>, or the <paramref name="defaultValue"/> if HasValue is false.
        /// </summary>
        /// <param name="value">The value to return</param>
        /// <param name="defaultValue">The default value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static T ValueOrDefault<T>(this Value<T> value, T defaultValue = default(T))
        {
            return value != null && value.HasValue ? value.Value : defaultValue;
        }

        /// <summary>
        /// Returns the value of <paramref name="result"/>, or the <paramref name="defaultValue"/> if HasValue is false.
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
        /// Returns the value of <paramref name="value"/> or an empty string if the value does not have a value.
        /// </summary>
        /// <param name="value">The value</param>
        public static string ValueOrEmpty(this Value<string> value)
        {
            return value != null && value.HasValue ? value.Value ?? string.Empty : string.Empty;
        }

        /// <summary>
        /// Returns the value, if HasValue is true, otherwise returns the other value.
        /// </summary>
        /// <param name="value">The first value</param>
        /// <param name="other">The alternate value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static Value<T> Or<T>(this Value<T> value, Value<T> other)
        {
            return value != null && value.HasValue ? value : other;
        }

        /// <summary>
        /// Returns the value, if HasValue is true, otherwise returns the other value.
        /// </summary>
        /// <param name="value">The first value</param>
        /// <param name="other">The alternate value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static T Or<T>(this Value<T> value, T other)
        {
            return value != null && value.HasValue ? value.Value : other;
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Select<TCursor, TInput, T>(this Result<Cursor<TCursor>, TInput> source, Func<TInput, Value<T>> getter)
        {
            if (source == null || !source.HasValue)
                return Value.Missing<T>();

            return getter(source.Value);
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <param name="index"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Select<TCursor, TInput, T>(this Result<Cursor<TCursor>, TInput> source, Func<TInput, ValueList<T>> getter, int index)
        {
            if (source == null || !source.HasValue)
                return Value.Missing<T>();

            ValueList<T> valueList = getter(source.Value);
            if (valueList == null || !valueList.HasValue || index < 0)
                return Value.Missing<T>();

            Value<T> value;
            return valueList.TryGetValue(index, out value) ? value : Value.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="ValueList{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ValueList<T> Select<TCursor, TInput, T>(this Result<Cursor<TCursor>, TInput> source, Func<TInput, ValueList<T>> getter)
        {
            if (source == null || !source.HasValue)
                return ValueList.Empty<T>();

            return getter(source.Value);
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static Value<TValue> Select<T, TValue>(this Value<T> source, Func<T, Value<TValue>> getter)
        {
            if (source == null || !source.HasValue)
                return Value.Missing<TValue>();

            return getter(source.Value);
        }
    }


    public static class PooExtensions
    {
        public static async Task<TResult> SelectMany<TInput, T, TResult>(this Task<TInput> task, Func<TInput, Task<T>> function, Func<TInput, T, TResult> projection)
        {
            TInput a = await task.ConfigureAwait(false);
            T b = await function(a).ConfigureAwait(false);

            return projection(a, b);
        }
    }
}