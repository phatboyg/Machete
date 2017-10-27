namespace Machete
{
    using System;
    using System.Collections.Generic;
    using Parsers;
    using TextParsers;


    public static class SelectExtensions
    {
        public static IParser<TInput, TResult> Select<TInput, T, TResult>(this IParser<TInput, T> parser, Func<T, TResult> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectParser<TInput, T, TResult>(parser, projection);
        }

        public static ITextParser Select(this ITextParser parser, Func<TextSpan, TextSpan> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectTextParser(parser, projection);
        }

        public static IParser<TContent, TResult> SelectMany<TContent, T, TValue, TResult>(
            this IParser<TContent, T> parser, Func<T, IParser<TContent, TValue>> selection,
            Func<T, TValue, TResult> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyParser<TContent, T, TValue, TResult>(parser, selection, projection);
        }

        public static ITextParser SelectMany(this ITextParser parser, Func<TextSpan, ITextParser> selection, Func<TextSpan, TextSpan, TextSpan> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyTextParser<TextSpan>(parser, selection, projection);
        }

        public static ITextParser<T> SelectMany<T>(this ITextParser parser, Func<TextSpan, ITextParser> selection, Func<TextSpan, TextSpan, T> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyTextParser<TextSpan, TextSpan, T>(parser, selection, projection);
        }

        public static ITextParser SelectMany<T>(this ITextParser<T> parser, Func<T, ITextParser> selection, Func<T, TextSpan, TextSpan> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyTextParser<T>(parser, selection, projection);
        }

        public static ITextParser<TResult> SelectMany<T, TResult>(this ITextParser<T> parser, Func<T, ITextParser> selection, Func<T, TextSpan, TResult> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyTextParser<T, TextSpan, TResult>(parser, selection, projection);
        }

        public static ITextParser<TResult> SelectMany<T, TValue, TResult>(this ITextParser<T> parser, Func<T, ITextParser<TValue>> selection, Func<T, TValue, TResult> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyTextParser<T, TValue, TResult>(parser, selection, projection);
        }
    }
}