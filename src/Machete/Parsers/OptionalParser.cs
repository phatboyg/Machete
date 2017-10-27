namespace Machete.Parsers
{
    /// <summary>
    /// Returns the first element of the input, or the default value
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class OptionalParser<TInput, T> :
        IParser<TInput, T>
    {
        readonly T _defaultValue;
        readonly IParser<TInput, T> _parser;

        public OptionalParser(IParser<TInput, T> parser, T defaultValue = default(T))
        {
            _parser = parser;
            _defaultValue = defaultValue;
        }

        Result<Cursor<TInput>, T> IParser<TInput, T>.Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, T> parsed = _parser.Parse(input);
            if (parsed.HasResult)
                return parsed;

            return new Success<Cursor<TInput>, T>(_defaultValue, input);
        }
    }
}