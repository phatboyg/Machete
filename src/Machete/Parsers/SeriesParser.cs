namespace Machete.Parsers
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Parses a series of results into a list
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class SeriesParser<TInput, T> :
        IParser<TInput, IReadOnlyList<T>>
    {
        readonly IParser<TInput, T> _parser;
        readonly SeriesOptions _options;

        public SeriesParser(IParser<TInput, T> parser, SeriesOptions options = SeriesOptions.None)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _options = options;
        }

        public Result<Cursor<TInput>, IReadOnlyList<T>> Parse(Cursor<TInput> input)
        {
            Cursor<TInput> next = input;

            Result<Cursor<TInput>, T> result = _parser.Parse(next);
            if (_options.HasFlag(SeriesOptions.AtLeastOne) && !result.HasResult)
                return new Unmatched<Cursor<TInput>, IReadOnlyList<T>>(input);

            var series = new List<T>();
            while (result.HasResult)
            {
                // not moving the cursor forward means the parser is stalled, so break
                if (next == result.Next)
                    break;

                series.Add(result.Result);
                next = result.Next;

                result = _parser.Parse(next);
            }

            return new Success<Cursor<TInput>, IReadOnlyList<T>>(series, next);
        }
    }
}