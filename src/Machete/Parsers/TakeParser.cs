namespace Machete.Parsers
{
    using System.Collections.Generic;


    /// <summary>
    /// Parses a series of results into a list, returning only the specified number of elements
    /// </summary>
    /// <typeparam name="TInput"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class TakeParser<TInput, T> :
        IParser<TInput, IReadOnlyList<T>>
    {
        readonly int _count;
        readonly IParser<TInput, T> _parser;

        public TakeParser(IParser<TInput, T> parser, int count)
        {
            _parser = parser;
            _count = count;
        }

        public Result<Cursor<TInput>, IReadOnlyList<T>> Parse(Cursor<TInput> input)
        {
            Cursor<TInput> next = input;

            var series = new List<T>(_count);
            for (int i = 0; i < _count; i++)
            {
                Result<Cursor<TInput>, T> r = _parser.Parse(next);
                if (!r.HasResult)
                    continue;
                
                // not moving the cursor forward means the parser is stalled, so break
                if (next == r.Next)
                    break;

                series.Add(r.Result);
                next = r.Next;
            }

            if (series.Count < _count)
                return new Unmatched<Cursor<TInput>, IReadOnlyList<T>>(next);

            return new Success<Cursor<TInput>, IReadOnlyList<T>>(series, next);
        }
    }
}