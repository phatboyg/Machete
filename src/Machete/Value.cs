namespace Machete
{
    using Values;


    public interface Value<out TValue> :
        IValue
    {
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
            return Cached<T>.Empty;
        }

        /// <summary>
        /// A missing value is one that is not present, and has no value.
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <returns></returns>
        public static Value<T> Missing<T>()
        {
            return Cached<T>.Missing;
        }

        public static Value<T> New<T>(T value)
        {
            return new ConstantValue<T>(value);
        }


        static class Cached<T>
        {
            public static readonly Value<T> Empty = GetEmptyValue();
            public static readonly Value<T> Missing = GetMissingValue();

            static Value<T> GetEmptyValue()
            {
                return new EmptyValue<T>();
            }

            static Value<T> GetMissingValue()
            {
                return new MissingValue<T>();
            }
        }
    }
}