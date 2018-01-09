namespace Machete.Parsers
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Parses a result, returning the first element if it exists, otherwise, it will return the specified default result
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class FirstOrDefaultParser<TInput, T> :
        IParser<TInput, T>
    {
        readonly IParser<TInput, IReadOnlyList<T>> _parser;
        readonly T _defaultValue;

        public FirstOrDefaultParser(IParser<TInput, IReadOnlyList<T>> parser, T defaultValue = default)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _defaultValue = defaultValue;
        }

        public Result<Cursor<TInput>, T> Parse(Cursor<TInput> input)
        {
            var parsed = _parser.Parse(input);
            
            return parsed.HasResult && parsed.Result.Count > 0
                ? new Success<Cursor<TInput>, T>(parsed.Result[0], parsed.Next)
                : new Success<Cursor<TInput>, T>(_defaultValue, input);
        }
    }
}