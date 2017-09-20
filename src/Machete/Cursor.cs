namespace Machete
{
    using Cursors;


    public interface Cursor<out TInput> :
        ICursor,
        IContext
    {
        /// <summary>
        /// The input at the current cursor position
        /// </summary>
        TInput Current { get; }

        /// <summary>
        /// Returns a cursor to the next input (check <see cref="ICursor.HasCurrent"/> to see if there is actually a value in the resulting Cursor)
        /// </summary>
        Cursor<TInput> Next();
    }


    public static class Cursor
    {
        public static Cursor<T> Empty<T>()
        {
            return Cached<T>.EmptyCursor;
        }

        static class Cached<T>
        {
            public static readonly Cursor<T> EmptyCursor = GetEmptyValue();

            static Cursor<T> GetEmptyValue()
            {
                return new EmptyCursor<T>();
            }
        }
    }
}