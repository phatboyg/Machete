namespace Machete
{
    using System;
    using Parsers;


    public static class ExceptExtensions
    {
        /// <summary>
        /// Parses an element only if the except parser is not matched
        /// </summary>
        public static Parser<TContent, T> Except<TContent, T, TExcept>(this Parser<TContent, T> parser,
            Parser<TContent, TExcept> except)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (except == null)
                throw new ArgumentNullException(nameof(except));

            return new ExceptParser<TContent, TExcept, T>(parser, except);
        }
    }
}