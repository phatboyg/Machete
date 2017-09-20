namespace Machete.Parsers
{
    public class PeekParser<TInput, TResult> :
        Parser<TInput, TResult>
    {
        readonly Parser<TInput, TResult> _parser;

        public PeekParser(Parser<TInput, TResult> parser)
        {
            _parser = parser;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, TResult> result = _parser.Parse(input);
            if (result.HasResult)
                return new Success<Cursor<TInput>, TResult>(result.Result, input);

            return new Unmatched<Cursor<TInput>, TResult>(input);
        }
    }
}