namespace Machete
{
    using Values;


    /// <summary>
    /// A value is a property on an entity that is mapped by the schema. The value type can be simple, or an entity.
    /// </summary>
    /// <typeparam name="TValue">The value type</typeparam>
    public interface Value<out TValue> :
        IValue
    {
        /// <summary>
        /// Returns the value for the property.
        /// </summary>
        /// <exception cref="ValueMissingException">Thrown if the value is not present.</exception>
        /// <exception cref="ValueConversionException">Thrown if the value is not convertible to the value type</exception>
        TValue Value { get; }
    }


    public static class Value
    {
        /// <summary>
        /// An empty value is one that is present, but has no value
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <returns></returns>
        public static Value<T> Empty<T>()
        {
            return Cached<T>.EmptyValue;
        }

        /// <summary>
        /// A missing value is one that is not present, and has no value.
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <returns></returns>
        public static Value<T> Missing<T>()
        {
            return Cached<T>.MissingValue;
        }

        /// <summary>
        /// Returns an invalid value for the specified slice
        /// </summary>
        /// <param name="slice"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Invalid<T>(TextSlice slice)
        {
            return new InvalidValue<T>(slice.SourceText, slice.SourceSpan);
        }

        /// <summary>
        /// Similar to a missing value for a ValueList in that it is not present and has no value.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> OutOfRange<T>(int index, int count)
        {
            return new OutOfRangeValue<T>(index, count);
        }

        /// <summary>
        /// Creates a constant value, using the value specified.
        /// </summary>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Value<T> Constant<T>(T value)
        {
            return new ConstantValue<T>(value);
        }


        static class Cached<T>
        {
            public static readonly Value<T> EmptyValue = new EmptyValue<T>();
            public static readonly Value<T> MissingValue = new MissingValue<T>();
        }
    }
}