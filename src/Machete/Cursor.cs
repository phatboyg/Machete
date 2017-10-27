namespace Machete
{
    using Cursors;


    /// <summary>
    /// A <see cref="T:Machete.Cursor" /> maintains an input position, is immutable, and can be used to return the next input position, if present
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    public interface Cursor<out TInput> :
        ICursor,
        IContext
    {
        /// <summary>
        /// The input at the current cursor position
        /// </summary>
        TInput Current { get; }

        /// <summary>
        /// Returns the next input cursor position (check <see cref="ICursor.HasCurrent"/> to see if there is actually a value in the resulting Cursor)
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
            public static readonly Cursor<T> EmptyCursor = new EmptyCursor<T>();
        }
    }
}