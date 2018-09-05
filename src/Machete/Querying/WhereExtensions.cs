namespace Machete
{
    using System;
    using Parsers;


    public static class WhereExtensions
    {
        /// <summary>
        /// Returns a parser if the condition evaluates to true.
        /// </summary>
        /// <param name="parser"></param>
        /// <param name="condition"></param>
        /// <typeparam name="TSchema"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IParser<TSchema, TResult> Where<TSchema, TResult>(this IParser<TSchema, TResult> parser, Func<TResult, bool> condition)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));

            if (condition == null)
                throw new ArgumentNullException(nameof(condition));

            return new WhereParser<TSchema, TResult>(parser, condition);
        }        
    }
}