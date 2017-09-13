namespace Machete
{
    /// <inheritdoc />
    /// <summary>
    /// Parses a text span into a series of text spans.
    /// </summary>
    public interface TextParser :
        TextParser<TextSpan>
    {
    }


    /// <summary>
    /// A parser that bridges the gap between a TextParser and a regular parser
    /// </summary>
    /// <typeparam name="TResult">The parser result type</typeparam>
    public interface TextParser<out TResult>
    {
        Result<TextSpan, TResult> Parse(ParseText text, TextSpan span);
    }
}