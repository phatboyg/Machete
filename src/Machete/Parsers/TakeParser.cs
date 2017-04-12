namespace Machete.Parsers
{
    using System.Collections.Generic;


    public class TakeParser<TInput, T> :
        Parser<TInput, IReadOnlyCollection<T>>
    {
        readonly int _count;
        readonly Parser<TInput, T> _parser;

        public TakeParser(Parser<TInput, T> parser, int count)
        {
            _parser = parser;
            _count = count;
        }

        public Result<Cursor<TInput>, IReadOnlyCollection<T>> Parse(Cursor<TInput> input)
        {
            Cursor<TInput> next = input;
            var results = new List<T>(_count);
            for (int i = 0; i < _count; i++)
            {
                Result<Cursor<TInput>, T> r = _parser.Parse(next);
                if (r.HasValue)
                {
                    if (next == r.Next)
                        break;

                    results.Add(r.Value);
                    next = r.Next;
                }
            }

            if (results.Count < _count)
                return new Unmatched<Cursor<TInput>, IReadOnlyCollection<T>>();

            return new Success<Cursor<TInput>, IReadOnlyCollection<T>>(results, next);
        }
    }
}