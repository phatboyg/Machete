namespace Machete
{
    using System;
    using Parsers;


    public static class ThenExtensions
    {
        /// <summary>
        /// Evaluates the first parser and if successful, the second parser is evaluated. If the second parser
        /// succeeds, the value of the second parser is returned, otherwise, the combination is unmatched and
        /// the cursor remains at the starting offset.
        /// </summary>
        /// <typeparam name="TInput">The input type</typeparam>
        /// <typeparam name="TFirst">The first parser type</typeparam>
        /// <typeparam name="TResult">The result type</typeparam>
        /// <param name="first">The first parser</param>
        /// <param name="second">The result parser</param>
        /// <returns>The result if matched, otherwise an unmatched result</returns>
        public static IParser<TInput, TResult> Then<TInput, TFirst, TResult>(this IParser<TInput, TFirst> first,
            IParser<TInput, TResult> second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));

            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new ThenParser<TInput, TFirst, TResult>(first, second);
        }
    }
}