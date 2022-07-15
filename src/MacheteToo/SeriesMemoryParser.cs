namespace MacheteToo;

using System.Buffers;


public class SeriesMemoryParser<T> :
    IMemoryParser<T>
{
    readonly bool _atLeastOne;
    readonly IMemoryParser<T> _parser;

    public SeriesMemoryParser(IMemoryParser<T> parser, bool atLeastOne)
    {
        _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        _atLeastOne = atLeastOne;
    }

    public Result<T> Parse(ReadOnlyMemory<T> memory)
    {
        var next = memory;

        var parsed = _parser.Parse(memory);
        if (parsed.Value == null)
            return _atLeastOne
                ? new Result<T>(parsed.Next)
                : new Result<T>(memory[..], parsed.Next);

        var bufferWriter = new ArrayBufferWriter<T>(parsed.Value.Value.Span.Length);

        while (parsed.Value.HasValue)
        {
            if (next.Span == parsed.Next.Span)
                break;

            if (!next.Span.Overlaps(parsed.Value.Value.Span))
                break;

            bufferWriter.Write(parsed.Value.Value.Span);

            next = parsed.Next;

            parsed = _parser.Parse(next);
        }

        return new Result<T>(bufferWriter.WrittenMemory, next);
    }
}