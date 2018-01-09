namespace Machete.Parsers
{
    using System;


    /// <summary>
    /// Parses uses the specified parser only if the except parser is unsuccessful
    /// </summary>
    /// <typeparam name="TInput">The input type</typeparam>
    /// <typeparam name="TExcept">Type except parser type</typeparam>
    /// <typeparam name="TResult">The parser type</typeparam>
    public class ExceptParser<TInput, TExcept, TResult> :
        IParser<TInput, TResult>
    {
        readonly IParser<TInput, TExcept> _except;
        readonly IParser<TInput, TResult> _parser;

        public ExceptParser(IParser<TInput, TResult> parser, IParser<TInput, TExcept> except)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _except = except ?? throw new ArgumentNullException(nameof(except));
        }

        Result<Cursor<TInput>, TResult> IParser<TInput, TResult>.Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, TExcept> excepted = _except.Parse(input);
            
            return excepted.HasResult ? new Unmatched<Cursor<TInput>, TResult>(input) : _parser.Parse(input);
        }
    }
}