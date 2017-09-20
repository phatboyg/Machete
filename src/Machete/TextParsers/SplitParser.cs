namespace Machete.TextParsers
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
            if (element.HasResult)
            {
                var separator = _separator.Parse(text, element.Next);
                if (separator.HasResult)
                    return new Success<TextSpan, TextSpan>(element.Result, separator.Next);

                if (element.Next == next)
                    return new Unmatched<TextSpan, TextSpan>(next);

                return new Success<TextSpan, TextSpan>(element.Result, element.Next);
            }

            return new Unmatched<TextSpan, TextSpan>(element.Next);
        }
    }
}