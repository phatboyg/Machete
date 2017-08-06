namespace Machete
{
    using System.Collections.Generic;
    using Cursors;


    public static class CursorExtensions
    {
        public static Result<Cursor<T>, TResult> Execute<T, TResult>(this Parser<T, TResult> parser, IReadOnlyList<T> elements)
        {
            var cursor = new ListCursor<T>(elements);

            return parser.Parse(cursor);
        }

        public static Result<Cursor<T>, TResult> Execute<T, TResult, T1>(this Parser<T, TResult> parser, IReadOnlyList<T> elements, T1 payload1)
            where T1 : class
        {
            var cursor = new ListCursor<T>(elements);

            cursor.GetOrAddContext(() => payload1);

            return parser.Parse(cursor);
        }

        /// <summary>
        /// Execute the parser on the text
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="text"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Result<Cursor<char>, TResult> Execute<TResult>(this Parser<char, TResult> parser, string text)
        {
            var cursor = new StringCursor(text);

            return parser.Parse(cursor);
        }
    }
}