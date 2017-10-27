namespace Machete
{
    using System;
    using System.Collections.Generic;
    using TextParsers;


    public static class CharExtensions
    {
        /// <summary>
        /// Parse a single character matching ch
        /// </summary>
        /// <param name="parser">The input parser</param>
        /// <param name="ch">The character to match</param>
        /// <returns>The character parser</returns>
        public static ITextParser Char(this ITextParser parser, char ch)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            bool IsChar(char c)
            {
                return c == ch;
            }

            return new CharTextParser(parser, IsChar);
        }

        /// <summary>
        /// Parse a single character matching the expression
        /// </summary>
        /// <param name="parser">The input parser</param>
        /// <param name="predicate">The character matching expression</param>
        /// <returns>The character parser</returns>
        public static ITextParser Char(this ITextParser parser, Func<char, bool> predicate)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return new CharTextParser(parser, predicate);
        }

        /// <summary>
        /// Parse any character that matches one of the specified characters
        /// </summary>
        /// <param name="parser">The input parser</param>
        /// <param name="chars"></param>
        /// <returns>The character parser</returns>
        public static ITextParser Char(this ITextParser parser, params char[] chars)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            var valid = new HashSet<char>(chars);

            bool IsValid(char c)
            {
                return valid.Contains(c);
            }

            return new CharTextParser(parser, IsValid);
        }

        /// <summary>
        /// Parse any character that matches one of the specified characters
        /// </summary>
        /// <param name="parser">The input parser</param>
        /// <returns>The character parser</returns>
        public static ITextParser Char(this ITextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new CharTextParser(parser, Ok);
        }

        static bool Ok(char c)
        {
            return true;
        }

        /// <summary>
        /// Parse any character that matches one of the specified characters
        /// </summary>
        /// <param name="parser">The input parser</param>
        /// <param name="chars"></param>
        /// <returns>The character parser</returns>
        public static ITextParser Chars(this ITextParser parser, params char[] chars)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new CharArrayTextParser(parser, chars);
        }

        /// <summary>
        /// Parse any character that matches one of the specified characters
        /// </summary>
        /// <param name="parser">The input parser</param>
        /// <param name="chars"></param>
        /// <returns>The character parser</returns>
        public static ITextParser Char(this ITextParser parser, IEnumerable<char> chars)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            var valid = new HashSet<char>(chars);

            bool IsValid(char c)
            {
                return valid.Contains(c);
            }

            return new CharTextParser(parser, IsValid);
        }

        public static ITextParser Whitespace(this ITextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return parser.Char(' ', '\t', '\r', '\n', '\x000C', '\x000B', '\x00A0', '\xFEFF');
        }

        public static ITextParser SkipWhitespace(this ITextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return parser.Char(' ', '\t', '\r', '\n', '\x000C', '\x000B', '\x00A0', '\xFEFF').ZeroOrMore();
        }

        public static ITextParser NewLine(this ITextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return parser.Char('\r')
                .FirstOrDefault()
                .Char('\n')
                .Or(parser.Char('\x2028').Or(parser.Char('\x2029')));
        }
    }
}