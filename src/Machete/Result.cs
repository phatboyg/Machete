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
        /// Returns true if the operation returned a successful result, otherwise false.
        /// </summary>
        bool HasResult { get; }

        /// <summary>
        /// The encapsulated result, which is only present if <see cref="HasResult"/> is true.
        /// </summary>
        TResult Result { get; }
    }
}