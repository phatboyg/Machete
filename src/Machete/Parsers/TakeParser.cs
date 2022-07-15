namespace Machete.Parsers
{
    using System;
    using System.Buffers;
    using System.Collections.Generic;


    /// <summary>
    /// Parses a series of results into a list, returning only the specified number of elements.
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
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
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


    public class TakeParserV2<TInput, T> :
        IParserV2<TInput, ReadOnlyMemory<T>>
    {
        readonly int _count;
        readonly IParserV2<TInput, T> _parser;

        public TakeParserV2(IParserV2<TInput, T> parser, int count)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _count = count;
        }

        public ValueResult<TInput, ReadOnlyMemory<T>> Parse(ValueCursor<TInput> input)
        {
            var next = input;

            var bufferWriter = new ArrayBufferWriter<T>(_count);
            var buffer = bufferWriter.GetSpan(_count);

            // TODO is this math right? only increment when we have a valid result?
            int index;
            for (index = 0; index < _count;)
            {
                var r = _parser.Parse(next);
                if (!r.HasResult)
                    continue;

                // not moving the cursor forward means the parser is stalled, so break
                if (next.Equals(r.Next))
                    break;

                buffer[index++] = r.Result;
                next = r.Next;
            }

            if (index < _count)
                return new ValueResult<TInput, ReadOnlyMemory<T>>(next);

            bufferWriter.Advance(index);

            return new ValueResult<TInput, ReadOnlyMemory<T>>(bufferWriter.WrittenMemory, next);
        }
    }
}