namespace Machete.Parsers
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Parses a single result and returns the match as a list with a single element
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class OneParser<TInput, T> :
        IParser<TInput, IReadOnlyList<T>>
    {
        readonly IParser<TInput, T> _parser;

        public OneParser(IParser<TInput, T> parser)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        }

        Result<Cursor<TInput>, IReadOnlyList<T>> IParser<TInput, IReadOnlyList<T>>.Parse(Cursor<TInput> input)
        {
            return _parser.Parse(input).Select(x => new[] {x});
        }
    }
}