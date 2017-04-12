namespace Machete.Parsers
{
    using System;


    public class WhereParser<TInput, TResult> :
        Parser<TInput, TResult>
    {
        readonly Parser<TInput, TResult> _parser;
        readonly Func<TResult, bool> _condition;

        public WhereParser(Parser<TInput, TResult> parser, Func<TResult, bool> condition)
        {
            _parser = parser;
            _condition = condition;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, TResult> parsed = _parser.Parse(input);
            if (parsed.HasValue)
            {
                if (_condition(parsed.Value))
                    return parsed;
            }

            return new Unmatched<Cursor<TInput>, TResult>(parsed.Next);
        }
    }
}