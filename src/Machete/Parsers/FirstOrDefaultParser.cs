namespace Machete.Parsers
{
    /// <summary>
    /// Returns the first element of the input, or the default value
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class FirstOrDefaultParser<TInput, T> :
        Parser<TInput, T>
    {
        readonly T _defaultValue;
        readonly Parser<TInput, T> _parser;

        public FirstOrDefaultParser(Parser<TInput, T> parser, T defaultValue = default(T))
        {
            _parser = parser;
            _defaultValue = defaultValue;
        }

        Result<Cursor<TInput>, T> Parser<TInput, T>.Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, T> parsed = _parser.Parse(input);
            if (parsed.HasValue)
                return parsed;

            return new Success<Cursor<TInput>, T>(_defaultValue, input);
        }
    }
}