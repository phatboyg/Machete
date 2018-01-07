namespace Machete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Parsers;
    using TextParsers;


    public static class SeriesExtensions
    {
        /// <summary>
        /// Returns zero or exatly one parsed element.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="defaultValue"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, T> Optional<TInput, T>(this IParser<TInput, T> parser, T defaultValue = default(T))
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new OptionalParser<TInput, T>(parser, defaultValue);
        }

        /// <summary>
        /// Returns a parsed element as a singular array instead of a single element.
        /// </summary>
        /// <param name="parser"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, IReadOnlyList<T>> One<TInput, T>(this IParser<TInput, T> parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new OneParser<TInput, T>(parser);
        }

        /// <summary>
        /// Returns a series of parsed elements as an array as long as there are one or more elements.
        /// </summary>
        /// <param name="parser"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, IReadOnlyList<T>> OneOrMore<TInput, T>(this IParser<TInput, T> parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new SeriesParser<TInput, T>(parser, SeriesOptions.AtLeastOne);
        }

        /// <summary>
        /// Returns the first item in the list, or the default value if the list is empty. The entire list is parsed, but only the first item is returned.
        /// The remaining items are ignored.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="defaultValue">The default value if the series if empty.</param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IParser<TInput, T> FirstOrDefault<TInput, T>(this IParser<TInput, IReadOnlyList<T>> parser, T defaultValue = default(T))
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new FirstOrDefaultParser<TInput, T>(parser, defaultValue);
        }

        /// <summary>
        /// Returns the first item in the list, or the default value if the list is empty. The entire list is parsed, but only the first item is returned.
        /// The remaining items are ignored.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="defaultValue">The default value if the series if empty.</param>
        /// <returns></returns>
        public static ITextParser FirstOrDefault(this ITextParser parser, TextSpan defaultValue = default(TextSpan))
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new FirstOrDefaultTextParser(parser, defaultValue);
        }

        /// <summary>
        /// Returns the single item from the list, if there is only a single item, otherwise, it returns the default value.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="defaultValue">The default value if the series does not contain a single item.</param>
        /// <typeparam name="TInput">The input type</typeparam>
        /// <typeparam name="T">The return type</typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, T> SingleOrDefault<TInput, T>(this IParser<TInput, IReadOnlyList<T>> parser, T defaultValue = default(T))
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new SingleOrDefaultParser<TInput, T>(parser, defaultValue);
        }

        /// <summary>
        /// Returns a series of parsed elements as an array.
        /// </summary>
        /// <param name="parser"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, IReadOnlyList<T>> ZeroOrMore<TInput, T>(this IParser<TInput, T> parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new SeriesParser<TInput, T>(parser);
        }

        /// <summary>
        /// Returns a series of parsed elements as an array.
        /// </summary>
        /// <param name="parser"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser ZeroOrMore(this ITextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new SeriesTextParser(parser, false);
        }

        /// <summary>
        /// Returns a series of parsed elements as an array.
        /// </summary>
        /// <param name="parser"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser OneOrMore(this ITextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new SeriesTextParser(parser, true);
        }

        /// <summary>
        /// Take exactly the number of elements specified from the document starting from the current position of the cursor.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="count"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static IParser<TInput, IReadOnlyList<T>> Take<TInput, T>(this IParser<TInput, T> parser, int count)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be >= 0");

            return new TakeParser<TInput, T>(parser, count);
        }

        /// <summary>
        /// Take the specified elements from the document starting from the current position of the cursor so long as the condition is true.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="condition"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, IReadOnlyList<TResult>> TakeWhile<TInput, TResult>(this IParser<TInput, TResult> parser, Func<TResult, bool> condition)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new TakeWhileParser<TInput, TResult>(parser, condition);
        }


        /// <summary>
        /// Returns a list of parsed elements.
        /// </summary>
        /// <param name="parser"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser<IReadOnlyList<TextSpan>> ToList(this ITextParser parser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            return new ToListTextParser(parser);
        }
    }
}