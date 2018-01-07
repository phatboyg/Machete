namespace Machete.Parsers
{
    /// <summary>
    /// Selects a matching result from the first parser, and if it does not return a result then use the second parser
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class OrParser<TInput, TResult> :
        IParser<TInput, TResult>
    {
        readonly IParser<TInput, TResult> _first;
        readonly IParser<TInput, TResult> _second;

        public OrParser(IParser<TInput, TResult> first, IParser<TInput, TResult> second)
        {
            _first = first;
            _second = second;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, TResult> result = _first.Parse(input);
            
            return result.HasResult ? result : _second.Parse(input);
        }
    }


    /// <summary>
    /// Selects a matching result from the first parser, and if it does not return a result then use the second parser
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public class OrParser<TInput, TResult, T1, T2> :
        IParser<TInput, TResult>
        where T1 : TResult
        where T2 : TResult
    {
        readonly IParser<TInput, T1> _first;
        readonly IParser<TInput, T2> _second;

        public OrParser(IParser<TInput, T1> first, IParser<TInput, T2> second)
        {
            _first = first;
            _second = second;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, T1> result = _first.Parse(input);
            
            return result.HasResult
                ? (Result<Cursor<TInput>, TResult>) result
                : (Result<Cursor<TInput>, TResult>) _second.Parse(input);
        }
    }
}