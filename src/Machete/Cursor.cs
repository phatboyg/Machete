namespace Machete
{
    using Cursors;


    public interface Cursor<out T> :
        ICursor
    {
        /// <summary>
        /// The cursor value
        /// </summary>
        T Value { get; }

        /// <summary>
        /// Returns a cursor to the next value (check <see cref="ICursor.HasValue"/> to see if there is actually a value in the resulting Cursor)
        /// </summary>
        Cursor<T> Next();
    }


    public static class Cursor
    {
        public static Cursor<T> Empty<T>()
        {
            return Cached<T>.Empty;
        }


        static class Cached<T>
        {
            public static readonly Cursor<T> Empty = GetEmptyValue();

            static Cursor<T> GetEmptyValue()
            {
                return new EmptyCursor<T>();
            }
        }
    }
}