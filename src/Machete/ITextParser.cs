namespace Machete
{
    /// <inheritdoc />
    /// <summary>
    /// Use this parser to parse text into a series of <see cref="TextSpan"/>s. Text parsers avoid creating, duplicating, or copying strings
    /// and are optimized for low memory overhead and fast text parsing.
    /// </summary>
    public interface ITextParser :
        ITextParser<TextSpan>
    {
    }


    /// <summary>
    /// Use this parser to parse text into a series of <typeparamref name="TResult"/>s. The underlying <see cref="ITextParser"/> usage ensures the
    /// lowest possible memory usage until conversion to the result type is performed.
    /// </summary>
    /// <typeparam name="TResult">The parser result type</typeparam>
    public interface ITextParser<out TResult>
    {
        Result<TextSpan, TResult> Parse(ParseText text, TextSpan span);
    }
}