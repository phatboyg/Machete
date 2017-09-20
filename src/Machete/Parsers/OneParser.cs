namespace Machete.Parsers
{
    using System.Collections.Generic;


    /// <summary>
    /// Parses a single result and returns the match as a list with a single element
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class OneParser<TInput, T> :
        Parser<TInput, IReadOnlyList<T>>
    {
        readonly Parser<TInput, T> _parser;

        public OneParser(Parser<TInput, T> parser)
        {
            _parser = parser;
        }

        Result<Cursor<TInput>, IReadOnlyList<T>> Parser<TInput, IReadOnlyList<T>>.Parse(Cursor<TInput> input)
        {
            return _parser.Parse(input).Select(x => new[] {x});
        }
    }
}