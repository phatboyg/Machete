namespace Machete
{
    /// <summary>
    /// The result of a parser, akin to a maybe monad
    /// </summary>
    /// <typeparam name="TInput">The parser input type</typeparam>
    /// <typeparam name="TResult">The parser result type</typeparam>
    public interface Result<out TInput, out TResult> :
        Result<TResult>
    {
        TInput Next { get; }
    }


    public interface Result<out TResult>
    {
        /// <summary>
        /// True if the result has a value, otherwise false
        /// </summary>
        bool HasValue { get; }

        /// <summary>
        /// The value of the result, if the HasValue property is true
        /// </summary>
        TResult Value { get; }
    }
}