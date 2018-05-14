namespace Machete
{
    using System.Collections.Generic;


    public static class ValueListExtensions
    {
        /// <summary>
        /// Returns a count of values in <see cref="ValueList{TValue}"/>
        /// </summary>
        /// <param name="source"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static int Count<TValue>(this ValueList<TValue> source)
        {
            if (source == null || !source.HasValue)
                return 0;

            int i = 0;
            for (;; i++)
                if (!source.TryGetValue(i, out _))
                    break;

            return i;
        }

        /// <summary>
        /// Returns a flattened list of Value<TValue> from a list of lists.
        /// </summary>
        /// <param name="source"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Value<TValue>> ToEnumerable<TValue>(this IEnumerable<ValueList<TValue>> source)
        {
            foreach (var list in source)
            {
                for (int i = 0;; i++)
                {
                    if (!list.TryGetValue(i, out var value))
                        break;

                    if (value.HasValue)
                        yield return value;
                }
            }
        }

        /// <summary>
        /// Converts a ValueList into an IEnumerable<Value<TValue>>.
        /// </summary>
        /// <param name="values"></param>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Value<TValue>> ToEnumerable<TValue>(this ValueList<TValue> values)
        {
            for (int i = 0;; i++)
            {
                if (!values.TryGetValue(i, out var value))
                    break;

                if (value.HasValue)
                    yield return value;
            }
        }
    }
}