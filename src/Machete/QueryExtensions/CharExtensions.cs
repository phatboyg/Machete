namespace Machete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Parsers;


    public static class CharExtensions
    {
        /// <summary>
        /// Parse a single character matching ch
        /// </summary>
        /// <typeparam name="TInput">The input parser type</typeparam>
        /// <param name="parser">The input parser</param>
        /// <param name="ch">The character to match</param>
        /// <returns>The character parser</returns>
        public static TextParser<char> Char(this TextParser parser, char ch)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new CharParser(c => c == ch);
        }

        /// <summary>
        /// Parse a single character matching the expression
        /// </summary>
        /// <typeparam name="TInput">The input parser type</typeparam>
        /// <param name="parser">The input parser</param>
        /// <param name="predicate">The character matching expression</param>
        /// <returns>The character parser</returns>
        public static TextParser<char> Char<TInput>(this TextParser parser,
            Func<char, bool> predicate)
        {
            if (parser == null)
                throw new ArgumentNullException("parser");

            return new CharParser(predicate);
        }

        /// <summary>
        /// Parse a single character matching any chars
        /// </summary>
        /// <typeparam name="TInput">The input parser type</typeparam>
        /// <param name="parser">The input parser</param>
        /// <param name="chars">The character set to match</param>
        /// <returns>The character parser</returns>
        public static TextParser<char> Char<TInput>(this TextParser parser, params char[] chars)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            List<char> allowed = chars.ToList();

            return new CharParser(c => allowed.Contains(c));
        }



        /// <summary>
        /// Parse a single character matching any chars
        /// </summary>
        /// <typeparam name="TInput">The input parser type</typeparam>
        /// <param name="parser">The input parser</param>
        /// <param name="chars">The character set to match</param>
        /// <returns>The character parser</returns>
        public static TextParser<char> Char<TInput>(this TextParser parser, IEnumerable<char> chars)
        {
            if (parser == null)
                throw new ArgumentNullException("parser");

            List<char> allowed = chars.ToList();
            if (allowed.Count == 0)
                throw new ArgumentException("At least one character must be specified");

            return new CharParser(c => allowed.Contains(c));
        }

//        public static TextParser Whitespace<TInput>(this TextParser parser)
//        {
//            if (parser == null)
//                throw new ArgumentNullException("parser");
//
//            return parser.Char(' ', '\t', '\r', '\n', '\x000C', '\x000B', '\x00A0', '\xFEFF');
//        }
//
//        public static Parser<TInput, char[]> SkipWhitespace<TInput>(this TextParser parser)
//        {
//            if (parser == null)
//                throw new ArgumentNullException("parser");
//
//            return parser.Char(' ', '\t', '\r', '\n', '\x000C', '\x000B', '\x00A0', '\xFEFF')
//                .ZeroOrMore();
//        }
//
//        public static TextParser NewLine<TInput>(this TextParser parser)
//        {
//            if (parser == null)
//                throw new ArgumentNullException("parser");
//
//            return parser.Char('\r').FirstOrDefault().Char('\n').Or(
//                parser.Char('\x2028').Or(parser.Char('\x2029')));
//        }
//
//        public static Parser<string, char[]> NewLine(this Parser<string, char> parser)
//        {
//            if (parser == null)
//                throw new ArgumentNullException("parser");
//
//            return parser.Chars('\r', '\n')
//                .Or(parser.Char('\r').One().Or(parser.Char('\n').One()));
//        }
//
//        public static Parser<char[], char[]> NewLine(this Parser<char[], char> parser)
//        {
//            if (parser == null)
//                throw new ArgumentNullException("parser");
//
//            return parser.Chars('\r', '\n').Or(parser.Char('\r', '\n').One());
//        }
//
//        public static Parser<TInput, string> String<TInput>(this Parser<TInput, char[]> parser)
//        {
//            return new CharToStringParser<TInput>(parser);
//        }
    }
}