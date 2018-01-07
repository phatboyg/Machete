namespace Machete
{
    using System;
    using Parsers;


    public static class PeekExtensions
    {
        /// <summary>
        /// Peek parses the input but does not move the Cursor forward
        /// </summary>
        /// <param name="parser"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, TResult> Peek<TInput, TResult>(this IParser<TInput, TResult> parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new PeekParser<TInput, TResult>(parser);
        }
    }
}