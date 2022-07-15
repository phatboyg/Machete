﻿namespace Machete.Parsers
{
    using System;


    /// <summary>
    /// Parses a single result, returning the element if the specified condition evaluates to true
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class WhereParser<TInput, TResult> :
        IParser<TInput, TResult>
    {
        readonly Func<TResult, bool> _condition;
        readonly IParser<TInput, TResult> _parser;

        public WhereParser(IParser<TInput, TResult> parser, Func<TResult, bool> condition)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _condition = condition ?? throw new ArgumentNullException(nameof(condition));
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            return _parser.Parse(input).Where(_condition);
        }
    }


    public class WhereParserV2<TInput, TResult> :
        IParserV2<TInput, TResult>
    {
        readonly Func<TResult, bool> _condition;
        readonly IParserV2<TInput, TResult> _parser;

        public WhereParserV2(IParserV2<TInput, TResult> parser, Func<TResult, bool> condition)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _condition = condition ?? throw new ArgumentNullException(nameof(condition));
        }

        public ValueResult<TInput, TResult> Parse(ValueCursor<TInput> input)
        {
            return _parser.Parse(input).Where(_condition);
        }
    }
}