namespace Machete
{
    using System;
    using Parsers;


    public static class ExceptExtensions
    {
        /// <summary>
        /// Parses an element only if the except parser is not matched
        /// </summary>
        public static Parser<TSchema, T> Except<TSchema, T, TExcept>(this Parser<TSchema, T> parser, Parser<TSchema, TExcept> except)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (except == null)
                throw new ArgumentNullException(nameof(except));

            return new ExceptParser<TSchema, TExcept, T>(parser, except);
        }

        /// <summary>
        /// Parses an element only if the except parser is not matched
        /// </summary>
        public static TextParser Except(this TextParser parser, TextParser except)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (except == null)
                throw new ArgumentNullException(nameof(except));

            return new ExceptTextParser(parser, except);
        }
    }
}