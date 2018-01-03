namespace Machete
{
    using System;
    using Parsers;
    using TextParsers;


    public static class OrExtensions
    {
        /// <summary>
        /// Return the first parser if it has a result, otherwise, return the second parser.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, T> Or<TInput, T>(this IParser<TInput, T> first, IParser<TInput, T> second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrParser<TInput, T>(first, second);
        }

        /// <summary>
        /// Return the first parser if it has a result, otherwise, return the second parser.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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

        /// <summary>
        /// Return the first parser if it has a result, otherwise, return the second parser.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ITextParser Or(this ITextParser first, ITextParser second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrTextParser(first, second);
        }

        /// <summary>
        /// Return the first parser if it has a result, otherwise, return the second parser.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
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