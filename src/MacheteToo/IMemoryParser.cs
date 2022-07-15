namespace MacheteToo;

public interface IMemoryParser<T>
{
    Result<T> Parse(ReadOnlyMemory<T> memory);
}



public interface ISequenceParser
{
    
}

