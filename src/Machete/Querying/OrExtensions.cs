namespace Machete
{
    using System;
    using Parsers;
    using TextParsers;


    public static class OrExtensions
    {
        public static IParser<TContent, T> Or<TContent, T>(this IParser<TContent, T> first, IParser<TContent, T> second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrParser<TContent, T>(first, second);
        }

        public static IParser<TInput, TResult> Or<TInput, TResult, T1, T2>(this IParser<TInput, T1> first, IParser<TInput, T2> second)
            where T1 : TResult
            where T2 : TResult
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrParser<TInput, TResult, T1, T2>(first, second);
        }

        public static ITextParser Or(this ITextParser first, ITextParser second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrTextParser(first, second);
        }

        public static ITextParser<T> Or<T>(this ITextParser<T> first, ITextParser<T> second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrTextParser<T>(first, second);
        }
    }
}