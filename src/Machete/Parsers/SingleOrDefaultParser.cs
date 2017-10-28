namespace Machete.Parsers
{
    using System.Collections.Generic;


    public class SingleOrDefaultParser<TInput, T> :
        IParser<TInput, T>
    {
        readonly IParser<TInput, IReadOnlyList<T>> _parser;
        readonly T _defaultValue;

        public SingleOrDefaultParser(IParser<TInput, IReadOnlyList<T>> parser, T defaultValue = default)
        {
            _parser = parser;
            _defaultValue = defaultValue;
        }

        public Result<Cursor<TInput>, T> Parse(Cursor<TInput> input)
        {
            var parsed = _parser.Parse(input);
            if (parsed.HasResult && parsed.Result.Count == 1)
            {
                return new Success<Cursor<TInput>, T>(parsed.Result[0], parsed.Next);
            }

            return new Success<Cursor<TInput>, T>(_defaultValue, input);
        }
    }
}