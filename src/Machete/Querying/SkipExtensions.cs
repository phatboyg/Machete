namespace Machete
{
    using System;
    using System.Collections.Generic;


    public static class SkipExtensions
    {
        /// <summary>
        /// Skip until the except parser is not matched (note this is a combined parser, and not a primitive one) -- yea!
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="parser"></param>
        /// <param name="until"></param>
        /// <returns></returns>
        public static IParser<TInput, IReadOnlyList<T>> Skip<TInput, T, TResult>(this IParser<TInput, T> parser, IParser<TInput, TResult> until)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (until == null)
                throw new ArgumentNullException(nameof(until));

            return parser.Except(until).ZeroOrMore();
        }

        /// <summary>
        /// Skip until the except parser is not matched and then return the until parser
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="until"></param>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TInput, TResult> SkipUntil<TInput, T, TResult>(this IParser<TInput, T> parser, IParser<TInput, TResult> until)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (until == null)
                throw new ArgumentNullException(nameof(until));

            return parser.Except(until).ZeroOrMore().Then(until);
        }

        /// <summary>
        /// Skip until the except parser is not matched (note this is a combined parser, and not a primitive
        /// one) and return the result parser
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TUntil"></typeparam>
        /// <param name="parser"></param>
        /// <param name="until"></param>
        /// <param name="resultParser"></param>
        /// <returns></returns>
        public static IParser<TInput, TResult> SkipUntil<TInput, T, TUntil, TResult>(this IParser<TInput, T> parser,
            IParser<TInput, TUntil> until, IParser<TInput, TResult> resultParser)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (until == null)
                throw new ArgumentNullException(nameof(until));
            if (resultParser == null)
                throw new ArgumentNullException(nameof(resultParser));

            return parser.Except(until).ZeroOrMore().Then(resultParser);
        }
    }
}