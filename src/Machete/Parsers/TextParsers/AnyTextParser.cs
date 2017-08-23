namespace Machete.Parsers.TextParsers
{
    public class AnyTextParser :
        TextParser
    {
        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            return new Success<TextSpan, TextSpan>(span.Take(1), span.Skip(1));
        }
    }
}