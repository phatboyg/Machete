namespace Machete
{
    using System.Collections.Generic;
    using Cursors;


    public static class CursorExtensions
    {
        /// <summary>
        /// Execute the parser on the text
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="elements"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Result<Cursor<T>, TResult> Execute<T, TResult>(this IParser<T, TResult> parser, IReadOnlyList<T> elements)
        {
            var cursor = new ListCursor<T>(elements);

            return parser.Parse(cursor);
        }

        /// <summary>
        /// Execute the parser on the text
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="elements"></param>
        /// <param name="context"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TContext"></typeparam>
        /// <returns></returns>
        public static Result<Cursor<T>, TResult> Execute<T, TResult, TContext>(this IParser<T, TResult> parser, IReadOnlyList<T> elements, TContext context)
            where TContext : class
        {
            Cursor<T> cursor = new ListCursor<T>(elements);

            cursor.GetOrAddContext(() => context);

            return parser.Parse(cursor);
        }

        /// <summary>
        /// Execute the parser on the text
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="text"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static Result<Cursor<char>, TResult> Execute<TResult>(this IParser<char, TResult> parser, string text)
        {
            var cursor = new StringCursor(text);

            return parser.Parse(cursor);
        }
    }
}