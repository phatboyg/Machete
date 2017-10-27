namespace Machete.TextParsers
{
    public class AnyTextParser :
        ITextParser
    {
        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.Length > 0)
                return new Success<TextSpan, TextSpan>(span, span.Tail);

            return new Unmatched<TextSpan, TextSpan>(span);
        }
    }
}