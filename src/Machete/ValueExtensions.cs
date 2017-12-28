namespace Machete
{
    using System;
    using System.Collections.Generic;


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
        /// Returns the value of <paramref name="value"/> or an empty string if the value does not have a value.
        /// </summary>
        /// <param name="value">The value</param>
        public static string ValueOrEmpty(this Value<string> value)
        {
            return value != null && value.HasValue ? value.Value ?? string.Empty : string.Empty;
        }

        /// <summary>
        /// Returns the Value<T>, if HasValue is true, otherwise returns the other value.
        /// </summary>
        /// <param name="value">The first value</param>
        /// <param name="other">The alternate value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static Value<T> Or<T>(this Value<T> value, Value<T> other)
        {
            return (value != null && value.HasValue ? value : other) ?? Value.Missing<T>();
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

            return getter(source.Value) ?? Value.Missing<TValue>();
        }

//        public static IEnumerable<Value<TValue>> Flatten<TValue>(this IEnumerable<ValueList<TValue>> result)
//        {
//            foreach (var valueList in result)
//            {
//                for (int i = 0;; i++)
//                {
//                    if (!valueList.TryGetValue(i, out var value))
//                        break;
//
//                    if (value.HasValue)
//                        yield return value;
//                }
//            }
//        }
    }
}