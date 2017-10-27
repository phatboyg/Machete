namespace Machete.X12.Parsers
{
    public class X12TextParser :
        ITextParser
    {
        readonly X12ParserSettings _settings;

        public X12TextParser(X12ParserSettings settings)
        {
            _settings = settings;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.IsEmpty)
                return new Unmatched<TextSpan, TextSpan>(span);

            if (span.Length == 2 && text[span.Start] == '"' && text[span.Start + 1] == '"')
                return new Success<TextSpan, TextSpan>(new TextSpan(span.Start, 2), TextSpan.FromBounds(span.Start + 2, span.End));

            return new Success<TextSpan, TextSpan>(span, span.Tail);
        }
    }
}