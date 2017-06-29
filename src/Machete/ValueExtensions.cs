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
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static bool IsEqualTo<TResult>(this Value<TResult> value, TResult expected)
        {
            return value.HasValue && value.Value.Equals(expected);
        }

        /// <summary>
        /// Select the property of the value, if <see cref="IValue.HasValue"/> is true
        /// </summary>
        /// <param name="value"></param>
        /// <param name="selector"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Value<TResult> Select<T, TResult>(this Value<T> value, Func<T, Value<TResult>> selector)
            where T : Entity
        {
            return value.HasValue ? selector(value.Value) : Value.Missing<TResult>();
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
        /// Safely returns the <see cref="Value{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="TCursor"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Value<TResult> Get<TSchema, TCursor, TResult>(this Result<Cursor<TSchema>, TCursor> source, Func<TCursor, Value<TResult>> getter)
        {
            try
            {
                if (source == null || !source.HasValue)
                    return Value.Missing<TResult>();

                return getter(source.Value);
            }
            catch
            {
                return Value.Missing<TResult>();
            }
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from the parsed result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="getter"></param>
        /// <param name="index"></param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="TSegment"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static Value<TValue> Get<TSchema, TSegment, TValue>(this Result<Cursor<TSchema>, TSegment> result, Func<TSegment, ValueList<TValue>> getter, int index)
        {
            try
            {
                if (result == null || !result.HasValue)
                    return Value.Missing<TValue>();

                ValueList<TValue> valueList = getter(result.Value);
                if (valueList == null || !valueList.HasValue || index < 0)
                    return Value.Missing<TValue>();

                Value<TValue> value;

                return valueList.TryGetValue(index, out value) ? value : Value.Missing<TValue>();
            }
            catch
            {
                return Value.Missing<TValue>();
            }
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="getter"></param>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Value<TResult> Get<TSource, TResult>(this Value<TSource> source, Func<TSource, Value<TResult>> getter)
        {
            try
            {
                if (source == null || !source.HasValue)
                    return Value.Missing<TResult>();

                return getter(source.Value);
            }
            catch
            {
                return Value.Missing<TResult>();
            }
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