namespace Machete.Parsers
{
    using System;
    using System.Diagnostics;


    /// <summary>
    /// Composes two parsers, the second of which must immediately follow the first, for the input to be matched.
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TFirst"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class ThenParser<TInput, TFirst, TResult> :
        IParser<TInput, TResult>
    {
        readonly IParser<TInput, TFirst> _first;
        readonly IParser<TInput, TResult> _second;

        public ThenParser(IParser<TInput, TFirst> first, IParser<TInput, TResult> second)
        {
            Debug.Assert(first != null);
            Debug.Assert(second != null);

            _first = first ?? throw new ArgumentNullException(nameof(first));
            _second = second ?? throw new ArgumentNullException(nameof(second));
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            return _first.Parse(input).Select((next, result) => _second.Parse(next));
        }
    }
}