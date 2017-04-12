namespace Machete.Cursors
{
    using System;


    public class EmptyCursor<T> :
        Cursor<T>
    {
        public bool HasValue => false;

        public T Value => default(T);

        public bool HasNext => false;

        public Cursor<T> Next()
        {
            throw new InvalidOperationException("There is no next cursor.");
        }
    }
}