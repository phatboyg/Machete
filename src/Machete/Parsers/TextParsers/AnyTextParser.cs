namespace Machete.Parsers.TextParsers
{
    public class AnyTextParser :
        TextParser
    {
        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.Length > 0)
                return new Success<TextSpan, TextSpan>(span.First, span.Skip(1));

            return new Unmatched<TextSpan, TextSpan>(span);
        }
    }
}