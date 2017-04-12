namespace Machete
{
    using Values;


    /// <summary>
    /// An array value is different from a repeating value in that it is separated differently.
    /// </summary>
    /// <typeparam name="TValue">The value type</typeparam>
    public interface ValueArray<TValue> :
        IValue
    {
        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        Value<TValue> this[int index] { get; }

        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        /// <param name="value">The output value</param>
        /// <returns>True if the value exists, otherwise false.</returns>
        bool TryGetValue(int index, out Value<TValue> value);
    }


    public static class ValueArray
    {
        public static ValueArray<T> Empty<T>()
        {
            return Cached<T>.Empty;
        }


        static class Cached<T>
        {
            public static readonly ValueArray<T> Empty = GetEmptyValue();
            public static readonly ValueArray<T> Missing = GetMissingValue();

            static ValueArray<T> GetEmptyValue()
            {
                return new EmptyValueArray<T>();
            }

            static ValueArray<T> GetMissingValue()
            {
                return new MissingValueArray<T>();
            }
        }
    }
}