namespace Machete.Parsers
{
    /// <summary>
    /// Parses uses the specified parser only if the except parser is unsuccessful
    /// </summary>
    /// <typeparam name="TInput">The input type</typeparam>
    /// <typeparam name="TExcept">Type except parser type</typeparam>
    /// <typeparam name="TResult">The parser type</typeparam>
    public class ExceptParser<TInput, TExcept, TResult> :
        Parser<TInput, TResult>
    {
        readonly Parser<TInput, TExcept> _except;
        readonly Parser<TInput, TResult> _parser;

        public ExceptParser(Parser<TInput, TResult> parser, Parser<TInput, TExcept> except)
        {
            _parser = parser;
            _except = except;
        }

        Result<Cursor<TInput>, TResult> Parser<TInput, TResult>.Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, TExcept> excepted = _except.Parse(input);
            if (excepted.HasValue)
                return new Unmatched<Cursor<TInput>, TResult>(input);

            return _parser.Parse(input);
        }
    }
}