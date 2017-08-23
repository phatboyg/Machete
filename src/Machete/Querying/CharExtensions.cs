namespace Machete
{
    using System;
    using System.Collections.Generic;
    using Parsers.TextParsers;


    public static class CharExtensions
    {
        /// <summary>
        /// Parse a single character matching ch
        /// </summary>
        /// <param name="parser">The input parser</param>
        /// <param name="ch">The character to match</param>
        /// <returns>The character parser</returns>
        public static TextParser Char(this TextParser parser, char ch)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new CharTextParser(parser, c => c == ch);
        }

        /// <summary>
        /// Parse a single character matching the expression
        /// </summary>
        /// <param name="parser">The input parser</param>
        /// <param name="predicate">The character matching expression</param>
        /// <returns>The character parser</returns>
        public static TextParser Char(this TextParser parser, Func<char, bool> predicate)
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
        public static TextParser Char(this TextParser parser, params char[] chars)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            var valid = new HashSet<char>(chars);

            return new CharTextParser(parser, valid.Contains);
        }

        /// <summary>
        /// Parse any character that matches one of the specified characters
        /// </summary>
        /// <param name="parser">The input parser</param>
        /// <param name="chars"></param>
        /// <returns>The character parser</returns>
        public static TextParser Chars(this TextParser parser, params char[] chars)
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
        public static TextParser Char(this TextParser parser, IEnumerable<char> chars)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            var valid = new HashSet<char>(chars);

            return new CharTextParser(parser, valid.Contains);
        }

        public static TextParser Whitespace(this TextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return parser.Char(' ', '\t', '\r', '\n', '\x000C', '\x000B', '\x00A0', '\xFEFF');
        }

        public static TextParser SkipWhitespace(this TextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return parser.Char(' ', '\t', '\r', '\n', '\x000C', '\x000B', '\x00A0', '\xFEFF').ZeroOrMore();
        }

        public static TextParser NewLine(this TextParser parser)
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