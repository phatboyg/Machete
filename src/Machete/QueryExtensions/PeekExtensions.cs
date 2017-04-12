namespace Machete
{
    using System;
    using Parsers;


    public static class PeekExtensions
    {
        /// <summary>
        /// Peek parses the input but does not move the Cursor forward
        /// </summary>
        /// <param name="peek"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static PeekParser<TInput, TResult> Peek<TInput, TResult>(this Parser<TInput, TResult> peek)
        {
            if (peek == null)
                throw new ArgumentNullException(nameof(peek));

            return new PeekParser<TInput, TResult>(peek);
        }
    }
}