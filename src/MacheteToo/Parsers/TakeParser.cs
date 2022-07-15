namespace MacheteToo.Parsers;

using System.Buffers;


public class TakeParser<TInput, T> :
    IParser<TInput, ReadOnlyMemory<T>>
{
    readonly int _count;
    readonly IParser<TInput, T> _parser;

    public TakeParser(IParser<TInput, T> parser, int count)
    {
        _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        _count = count;
    }

    public CursorResult<TInput, ReadOnlyMemory<T>> Parse(Cursor<TInput> input)
    {
        var next = input;

        var bufferWriter = new ArrayBufferWriter<T>(_count);
        var buffer = bufferWriter.GetSpan(_count);

        // TODO is this math right? only increment when we have a valid result?
        int index;
        for (index = 0; index < _count;)
        {
            var r = _parser.Parse(next);
            if (r.Value == null)
                continue;

            // not moving the cursor forward means the parser is stalled, so break
            if (next.Equals(r.Next))
                break;

            buffer[index++] = r.Value;
            next = r.Next;
        }

        if (index < _count)
            return new CursorResult<TInput, ReadOnlyMemory<T>>(next);

        bufferWriter.Advance(index);

        return new CursorResult<TInput, ReadOnlyMemory<T>>(bufferWriter.WrittenMemory, next);
    }
}