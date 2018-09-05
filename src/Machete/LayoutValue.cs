namespace Machete
{
    using Layouts;


    public static class LayoutValue
    {
        /// <summary>
        /// A missing value is one that has no value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Layout<T> Missing<T>()
            where T : Layout
        {
            return Cached<T>.Missing;
        }

        
        static class Cached<T>
            where T : Layout
        {
            public static readonly Layout<T> Missing = new MissingLayout<T>();
        }
    }
}