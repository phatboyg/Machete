namespace Machete
{
    using System;
    using Parsers;
    using TextParsers;


    public static class SelectExtensions
    {
        /// <summary>
        /// Selects a property <see cref="T"/> from the current parser and returns the parser for that value.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, TResult> Select<TInput, T, TResult>(this IParser<TInput, T> parser, Func<T, TResult> projector)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new SelectParser<TInput, T, TResult>(parser, projector);
        }

        /// <summary>
        /// Selects a value property from the current value parser and returns the parser for that value.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static IParser<TInput, Value<TResult>> Select<TInput, T, TResult>(this IParser<TInput, Value<T>> parser, Func<T, Value<TResult>> projector)
            where TInput : Entity
            where T : Entity
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new SelectValueParser<TInput, T, TResult>(parser, projector);
        }

        /// <summary>
        /// Selects a matching result from a text parser and applies a projection to the result type returning a new parser.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="projector"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser Select(this ITextParser parser, Func<TextSpan, TextSpan> projector)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new SelectTextParser(parser, projector);
        }

        /// <summary>
        /// Applies a projection to a list of parsers who maintain a list of parsers, returning a flattened list of parsers.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="selection"></param>
        /// <param name="projector"></param>
        /// <typeparam name="TContent"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TContent, TResult> SelectMany<TContent, T, TValue, TResult>(
            this IParser<TContent, T> parser, Func<T, IParser<TContent, TValue>> selection,
            Func<T, TValue, TResult> projector)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new SelectManyParser<TContent, T, TValue, TResult>(parser, selection, projector);
        }

        /// <summary>
        /// Applies a projection to a list of text parsers who maintain a list of parsers, returning a flattened list of parsers.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="selection"></param>
        /// <param name="projector"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser SelectMany(this ITextParser parser, Func<TextSpan, ITextParser> selection, Func<TextSpan, TextSpan, TextSpan> projector)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new SelectManyTextParser<TextSpan>(parser, selection, projector);
        }

        /// <summary>
        /// Applies a projection to a list of text parsers who maintain a list of parsers, returning a flattened list of parsers.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="selection"></param>
        /// <param name="projector"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser<T> SelectMany<T>(this ITextParser parser, Func<TextSpan, ITextParser> selection, Func<TextSpan, TextSpan, T> projector)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new SelectManyTextParser<TextSpan, TextSpan, T>(parser, selection, projector);
        }

        /// <summary>
        /// Applies a projection to a list of text parsers who maintain a list of parsers, returning a flattened list of parsers.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="selection"></param>
        /// <param name="projector"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser SelectMany<T>(this ITextParser<T> parser, Func<T, ITextParser> selection, Func<T, TextSpan, TextSpan> projector)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new SelectManyTextParser<T>(parser, selection, projector);
        }

        /// <summary>
        /// Applies a projection to a list of text parsers who maintain a list of parsers, returning a flattened list of parsers.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="selection"></param>
        /// <param name="projector"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser<TResult> SelectMany<T, TResult>(this ITextParser<T> parser, Func<T, ITextParser> selection, Func<T, TextSpan, TResult> projector)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new SelectManyTextParser<T, TextSpan, TResult>(parser, selection, projector);
        }

        /// <summary>
        /// Applies a projection to a list of text parsers who maintain a list of parsers, returning a flattened list of parsers.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="selection"></param>
        /// <param name="projector"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser<TResult> SelectMany<T, TValue, TResult>(this ITextParser<T> parser, Func<T, ITextParser<TValue>> selection, Func<T, TValue, TResult> projector)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projector == null)
                throw new ArgumentNullException(nameof(projector));

            return new SelectManyTextParser<T, TValue, TResult>(parser, selection, projector);
        }
    }
}