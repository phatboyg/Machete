namespace Machete
{
    using System;
    using System.Collections.Generic;
    using Parsers;
    using Parsers.TextParsers;


    public static class SelectExtensions
    {
        public static Parser<TInput, TResult> Select<TInput, T, TResult>(this Parser<TInput, T> parser, Func<T, TResult> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectParser<TInput, T, TResult>(parser, projection);
        }

        public static TextParser Select(this TextParser parser, Func<TextSpan, TextSpan> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectTextParser(parser, projection);
        }

        public static Parser<TContent, TResult> SelectMany<TContent, T, TValue, TResult>(
            this Parser<TContent, T> parser, Func<T, Parser<TContent, TValue>> selection,
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

        public static TextParser SelectMany(this TextParser parser, Func<TextSpan, TextParser> selection, Func<TextSpan, TextSpan, TextSpan> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyTextParser<TextSpan, TextSpan>(parser, selection, projection);
        }

        public static TextParser<T> SelectMany<T>(this TextParser parser, Func<TextSpan, TextParser> selection, Func<TextSpan, TextSpan, T> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyTextParser<TextSpan, TextSpan, T>(parser, selection, projection);
        }

        public static TextParser SelectMany<T>(this TextParser<T> parser, Func<T, TextParser> selection, Func<T, TextSpan, TextSpan> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyTextParser<T, TextSpan>(parser, selection, projection);
        }

        public static TextParser<TResult> SelectMany<T, TResult>(this TextParser<T> parser, Func<T, TextParser> selection, Func<T, TextSpan, TResult> projection)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (selection == null)
                throw new ArgumentNullException(nameof(selection));
            if (projection == null)
                throw new ArgumentNullException(nameof(projection));

            return new SelectManyTextParser<T, TextSpan, TResult>(parser, selection, projection);
        }

        public static TextParser<TResult> SelectMany<T, TValue, TResult>(this TextParser<T> parser, Func<T, TextParser<TValue>> selection, Func<T, TValue, TResult> projection)
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