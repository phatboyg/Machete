namespace Machete.Parsers
{
    using System.Collections.Generic;


    /// <summary>
    /// Parses a result, returning a single element if and only if there is exactly one result, otherwise, it will return the specified default result
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
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
            
            return parsed.HasResult && parsed.Result.Count == 1
                ? new Success<Cursor<TInput>, T>(parsed.Result[0], parsed.Next)
                : new Success<Cursor<TInput>, T>(_defaultValue, input);
        }
    }
}