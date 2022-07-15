namespace MacheteToo;

public static class SelectParserExtensions
{
    public static IParser<TInput, TResult> Select<TInput, T, TResult>(this IParser<TInput, T> parser, Func<T, TResult> projector)
    {
        if (parser == null)
            throw new ArgumentNullException(nameof(parser));

        if (projector == null)
            throw new ArgumentNullException(nameof(projector));

        return new SelectParser<TInput, T, TResult>(parser, projector);
    }

    /// <summary>
    /// Safely returns the <see cref="Result{TResult}"/> from the parsed result.
    /// </summary>
    /// <param name="result"></param>
    /// <param name="projector"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Result<T> Select<T>(this Result<T> result, Func<ReadOnlyMemory<T>, Result<T>> projector)
    {
        return result.Value != null
            ? projector(result.Value.Value)
            : new Result<T>(result.Next);
    }
}