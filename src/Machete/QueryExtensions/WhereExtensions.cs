namespace Machete
{
    using System;
    using Parsers;


    public static class WhereExtensions
    {
        public static Parser<TSchema, TResult> Where<TSchema, TResult>(this Parser<TSchema, TResult> parser, Func<TResult, bool> condition)
        {
            if (parser == null)
                throw new ArgumentNullException(nameof(parser));
            if (condition == null)
                throw new ArgumentNullException(nameof(condition));

            return new WhereParser<TSchema, TResult>(parser, condition);
        }        
    }
}