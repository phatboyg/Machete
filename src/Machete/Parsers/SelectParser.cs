namespace Machete.Parsers
{
    using System;


    /// <summary>
    /// Selects a matching result from the parser, and applies a projection to the result type
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    public class SelectParser<TInput, T, TResult> :
        IParser<TInput, TResult>
    {
        readonly IParser<TInput, T> _parser;
        readonly Func<T, TResult> _projector;

        public SelectParser(IParser<TInput, T> parser, Func<T, TResult> projector)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _projector = projector ?? throw new ArgumentNullException(nameof(projector));
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            return _parser.Parse(input).Select(x => _projector(x));
        }
    }
}