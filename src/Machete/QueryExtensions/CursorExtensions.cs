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