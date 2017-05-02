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
            if (value.HasValue)
                return selector(value.Value);

            return Value.Missing<TResult>();
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