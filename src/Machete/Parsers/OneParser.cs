namespace Machete.Parsers
{
    using System.Collections.Generic;


    public class OneParser<TInput, T> :
        Parser<TInput, IReadOnlyCollection<T>>
    {
        readonly Parser<TInput, T> _parser;

        public OneParser(Parser<TInput, T> parser)
        {
            _parser = parser;
        }

        Result<Cursor<TInput>, IReadOnlyCollection<T>> Parser<TInput, IReadOnlyCollection<T>>.Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, T> result = _parser.Parse(input);
            if (result.HasValue)
                return new Success<Cursor<TInput>, IReadOnlyCollection<T>>(new[] {result.Value}, result.Next);

            return new Unmatched<Cursor<TInput>, IReadOnlyCollection<T>>(input);
        }
    }
}