namespace MacheteToo;

public static class ResultExtensions
{
    public static CursorResult<TInput, TResult> Select<TInput, T, TResult>(this CursorResult<TInput, T> result, Func<T, TResult> projector)
    {
        return result.Value != null
            ? new CursorResult<TInput, TResult>(projector(result.Value), result.Next)
            : new CursorResult<TInput, TResult>(result.Next);
    }

    public static CursorResult<TInput, TResult> Where<TInput, TResult>(this CursorResult<TInput, TResult> result, Func<TResult, bool> filter)
    {
        if (result.Value != null && filter(result.Value))
            return result;

        return new CursorResult<TInput, TResult>(result.Next);
    }

    public static Result<TInput> Where<TInput>(this Result<TInput> result, Func<ReadOnlyMemory<TInput>, bool> filter)
    {
        if (result.Value != null && filter(result.Value.Value))
            return result;

        return new Result<TInput>(result.Next);
    }
}