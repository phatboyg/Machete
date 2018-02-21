namespace Machete
{
    public static class ValueInfoHelper
    {
        /// <summary>
        /// A missing value is one that is not present, and has no value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ValueInfo Missing<T>()
        {
            return Cached<T>.Missing;
        }


        static class Cached<T>
        {
            public static readonly ValueInfo Missing = new MissingValueInfo<T>();
        }
    }
}