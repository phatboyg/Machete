namespace Machete
{
    /// <summary>
    /// A parser determines if an input matches the requirements and if so returns the result
    /// </summary>
    /// <typeparam name="TInput">The parser input type</typeparam>
    /// <typeparam name="TResult">The parser result type</typeparam>
    public interface IParser<TInput, out TResult>
    {
        Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input);
    }


    /// <summary>
    /// A parser determines if an input matches the requirements and if so returns the result
    /// </summary>
    /// <typeparam name="TInput">The parser input type</typeparam>
    /// <typeparam name="TResult">The parser result type</typeparam>
    public interface IParserV2<TInput, TResult>
    {
        ValueResult<TInput, TResult> Parse(ValueCursor<TInput> input);
    }
}