namespace MacheteToo;

public class AnyMemoryParser<T> :
    IMemoryParser<T>
{
    public Result<T> Parse(ReadOnlyMemory<T> memory)
    {
        if (memory.Length > 0)
            return new Result<T>(memory, memory);

        return new Result<T>(memory);
    }
}

