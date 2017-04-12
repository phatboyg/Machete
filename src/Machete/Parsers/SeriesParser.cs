namespace Machete.Parsers
{
    using System.Collections.Generic;


    public class SeriesParser<TInput, T> :
        Parser<TInput, IReadOnlyCollection<T>>
    {
        readonly bool _atLeastOne;
        readonly Parser<TInput, T> _parser;

        public SeriesParser(Parser<TInput, T> parser, bool atLeastOne)
        {
            _parser = parser;
            _atLeastOne = atLeastOne;
        }

        public Result<Cursor<TInput>, IReadOnlyCollection<T>> Parse(Cursor<TInput> input)
        {
            Cursor<TInput> next = input;
            var results = new List<T>();

            Result<Cursor<TInput>, T> r = _parser.Parse(next);
            if (_atLeastOne && !r.HasValue)
                return new Unmatched<Cursor<TInput>, IReadOnlyCollection<T>>(input);

            while (r.HasValue)
            {
                if (next == r.Next)
                    break;

                results.Add(r.Value);
                next = r.Next;

                r = _parser.Parse(next);
            }

            return new Success<Cursor<TInput>, IReadOnlyCollection<T>>(results.ToArray(), next);
        }
    }
}