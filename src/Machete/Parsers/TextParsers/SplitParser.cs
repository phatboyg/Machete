namespace Machete.Parsers.TextParsers
{
    public class SplitParser :
        TextParser
    {
        readonly TextParser _element;
        readonly TextParser _separator;

        public SplitParser(TextParser element, TextParser separator)
        {
            _element = element;
            _separator = separator;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.IsEmpty)
                return new Unmatched<TextSpan, TextSpan>(span);

            var next = span;

            var element = _element.Parse(text, span);
            if (element.HasValue)
            {
                var separator = _separator.Parse(text, element.Next);
                if (separator.HasValue)
                    return new Success<TextSpan, TextSpan>(element.Value, separator.Next);

                if (element.Next == next)
                    return new Unmatched<TextSpan, TextSpan>(next);

                return new Success<TextSpan, TextSpan>(element.Value, element.Next);
            }

            return new Unmatched<TextSpan, TextSpan>(element.Next);
        }
    }
}