namespace MacheteToo;

using System.Buffers;
using System.IO.Pipelines;
using System.Text;


public class MemoryParser<T> :
    IMemoryParser<T>
{
    readonly Func<T, bool> _condition;
    readonly IMemoryParser<T> _parser;

    public MemoryParser(IMemoryParser<T> parser, Func<T, bool> condition)
    {
        _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        _condition = condition ?? throw new ArgumentNullException(nameof(condition));
    }

    public Result<T> Parse(ReadOnlyMemory<T> memory)
    {
        return _parser.Parse(memory)
            .Where(x => x.Length > 0 && _condition(memory.Span[0]))
            .Select(next => new Result<T>(next.Slice(0, 1), next[1..]));
    }
}


public readonly ref struct SequenceResult
{
    public readonly ReadOnlySequence<byte> Buffer;
    public readonly ReadOnlySequence<byte> Next;
    public readonly bool IsValid;

    public SequenceResult(ReadOnlySequence<byte> buffer, ReadOnlySequence<byte> next)
    {
        Buffer = buffer;
        Next = next;

        IsValid = true;
    }
}


/*
 * 
        private static SequencePosition ParseLines(Employee[] employeeRecords, in ReadOnlySequence<byte> buffer, ref int position)
        {
            var reader = new SequenceReader<byte>(buffer);

            // Read the whole line till the new line is found
            while (reader.TryReadTo(out ReadOnlySpan<byte> line, (byte)'\n', true))
            {
                var employee = LineParser.ParseLine(line); // we have a line to parse

                if (employee is { }) // if the returned value is valid Employee object
                    employeeRecords[position++] = employee.Value;
            }

            return reader.Position; // returning the Last position of the reader
        }
 */


public class ConvertToStringParser :
    ISequenceParser
{
    public ReadOnlySpan<char> Text(ref ReadOnlySequence<byte> buffer)
    {
        ReadOnlySpan<char> text = Encoding.UTF8.GetString(buffer);

        return text.Trim();
    }
}


public class ReadToStringParser :
    ISequenceParser
{
    readonly byte[] _delimiter;

    public ReadToStringParser(string delimiter, Encoding? encoding = null)
    {
        _delimiter = (encoding ?? Encoding.UTF8).GetBytes(delimiter);
    }

    public SequenceResult Parse(in ReadOnlySequence<byte> buffer)
    {
        var delimiter = _delimiter.AsSpan();

        var reader = new SequenceReader<byte>(buffer);

        return reader.TryReadToAny(out ReadOnlySequence<byte> span, delimiter)
            ? new SequenceResult(span, reader.UnreadSequence)
            : reader.Remaining > 0
                ? new SequenceResult(reader.UnreadSequence, ReadOnlySequence<byte>.Empty)
                : default;
    }
}


public class LineTextParser :
    ISequenceParser
{
    readonly byte[] _delimiters;

    public LineTextParser()
    {
        _delimiters = new[] { (byte)'\r', (byte)'\n' };
    }

    public SequenceResult Parse(PipeReader pipeReader)
    {
        if (pipeReader.TryRead(out var readResult))
        {
            var reader = new SequenceReader<byte>(readResult.Buffer);

            if (reader.TryReadToAny(out ReadOnlySequence<byte> matched, _delimiters, false))
            {
                reader.AdvancePast((byte)'\r');
                reader.AdvancePast((byte)'\n');

                pipeReader.AdvanceTo(reader.Position);
                return new SequenceResult(matched, reader.UnreadSequence);
            }

            if (readResult.IsCompleted && readResult.Buffer.Length > 0)
            {
                pipeReader.AdvanceTo(readResult.Buffer.End);
                return new SequenceResult(readResult.Buffer, reader.UnreadSequence);
            }
        }


        return default;
    }
}