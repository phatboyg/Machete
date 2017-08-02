namespace Machete
{
    using Values;


    /// <summary>
    /// A value list is a list of values (yeah, it's really that profound) which are
    /// typically sourced from a fragment with a repitition character.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public interface ValueList<TValue> :
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


    public static class ValueList
    {
        public static ValueList<T> Empty<T>()
        {
            return Cached<T>.EmptyValueList;
        }

        public static ValueList<T> Missing<T>()
        {
            return Cached<T>.MissingValueList;
        }


        static class Cached<T>
        {
            public static readonly ValueList<T> EmptyValueList = GetEmptyValue();
            public static readonly ValueList<T> MissingValueList = GetMissingValue();

            static ValueList<T> GetEmptyValue()
            {
                return new EmptyValueList<T>();
            }

            static ValueList<T> GetMissingValue()
            {
                return new MissingValueList<T>();
            }
        }
    }
}