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
        /// Returns a string.Empty if the <see cref="IValue.HasValue"/> is false or <see cref="Value{TValue}"/> equals null
        /// </summary>
        /// <param name="value"></param>
        /// <returns><see cref="Value{TValue}.Value"/> or string.Empty</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string ValueOrEmpty(this Value<string> value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            
            return !value.HasValue ? string.Empty : value.Value;
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