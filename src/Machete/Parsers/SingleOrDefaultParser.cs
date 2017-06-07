namespace Machete.Parsers
{
    using System.Collections.Generic;


    public class SingleOrDefaultParser<TInput, T> :
        Parser<TInput, T>
    {
        readonly Parser<TInput, IReadOnlyList<T>> _parser;
        readonly T _defaultValue;

        public SingleOrDefaultParser(Parser<TInput, IReadOnlyList<T>> parser, T defaultValue = default(T))
        {
            _parser = parser;
            _defaultValue = defaultValue;
        }

        public Result<Cursor<TInput>, T> Parse(Cursor<TInput> input)
        {
            var parsed = _parser.Parse(input);
            if (parsed.HasValue && parsed.Value.Count == 1)
            {
                return new Success<Cursor<TInput>, T>(parsed.Value[0], parsed.Next);
            }

            return new Success<Cursor<TInput>, T>(_defaultValue, input);
        }
    }
}