namespace Machete
{
    using System;
    using Parsers;
    using TextParsers;


    public static class ExceptExtensions
    {
        /// <summary>
        /// Parses an element only if the except parser is not matched
        /// </summary>
        public static IParser<TSchema, T> Except<TSchema, T, TExcept>(this IParser<TSchema, T> parser, IParser<TSchema, TExcept> except)
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
        public static ITextParser Except(this ITextParser parser, ITextParser except)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (except == null)
                throw new ArgumentNullException(nameof(except));

            return new ExceptTextParser(parser, except);
        }
    }
}