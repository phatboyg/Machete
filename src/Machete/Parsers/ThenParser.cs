namespace Machete.Parsers
{
    using System.Diagnostics;


    /// <summary>
    /// Composes two parsers, the second of which must immediately follow the first, for the input to be matched.
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class ThenParser<TInput, TFirst, TResult> :
        Parser<TInput, TResult>
    {
        readonly Parser<TInput, TFirst> _first;
        readonly Parser<TInput, TResult> _second;

        public ThenParser(Parser<TInput, TFirst> first, Parser<TInput, TResult> second)
        {
            Debug.Assert(first != null);
            Debug.Assert(second != null);

            _first = first;
            _second = second;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, TFirst> parsed = _first.Parse(input);
            if (parsed.HasValue)
            {
                var nextResult = _second.Parse(parsed.Next);
                if (nextResult.HasValue)
                    return nextResult;
            }

            return new Unmatched<Cursor<TInput>, TResult>(parsed.Next);
        }
    }
}