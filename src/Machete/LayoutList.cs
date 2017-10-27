namespace Machete
{
    using Layouts;


    public interface LayoutList<TLayout> :
        ILayout
        where TLayout : Layout
    {
        /// <summary>
        ///     Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        Layout<TLayout> this[int index] { get; }

        /// <summary>
        ///     Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        /// <param name="value">The output value</param>
        /// <returns>True if the value exists, otherwise false.</returns>
        bool TryGetValue(int index, out Layout<TLayout> value);
    }


    public static class LayoutList
    {
        public static LayoutList<T> Missing<T>()
            where T : Layout
        {
            return Cached<T>.MissingLayoutList;
        }


        static class Cached<T>
            where T : Layout
        {
            public static readonly LayoutList<T> MissingLayoutList = new MissingLayoutList<T>();
        }
    }
}