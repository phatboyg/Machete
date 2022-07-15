namespace MacheteToo;

/// <summary>
/// The result of a <see cref="IParser{TInput,TResult}.Parse"/> method.
/// </summary>
/// <typeparam name="TInput">The parser input type</typeparam>
/// <typeparam name="TResult">The result type</typeparam>
public readonly ref struct CursorResult<TInput, TResult>
{
    public readonly Cursor<TInput> Next;
    public readonly TResult? Value;

    public CursorResult(TResult value, Cursor<TInput> next)
    {
        Next = next;
        Value = value;
    }

    public CursorResult(Cursor<TInput> next)
    {
        Next = next;

        Value = default;
    }
}


/// <summary>
/// The result of a <see cref="IMemoryParser{TInput}.Parse"/> method.
/// </summary>
/// <typeparam name="T">The parser input type</typeparam>
public readonly struct Result<T>
{
    public readonly ReadOnlyMemory<T> Next;
    public readonly ReadOnlyMemory<T>? Value;

    public Result(ReadOnlyMemory<T> value, ReadOnlyMemory<T> next)
    {
        Next = next;
        Value = value;
    }

    public Result(ReadOnlyMemory<T> next)
    {
        Next = next;

        Value = default;
    }
}


/// <summary>
/// The result of a <see cref="IMemoryParser{TInput}.Parse"/> method.
/// </summary>
/// <typeparam name="T">The parser input type</typeparam>
public readonly struct ElementResult<T>
{
    public readonly ReadOnlyMemory<T> Next;
    public readonly T? Value;

    public ElementResult(T value, ReadOnlyMemory<T> next)
    {
        Next = next;
        Value = value;
    }

    public ElementResult(ReadOnlyMemory<T> next)
    {
        Next = next;

        Value = default;
    }
}