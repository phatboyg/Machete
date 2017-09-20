namespace Machete.TextParsers
{
    public class SplitWithTerminatorParser :
        TextParser
    {
        readonly TextParser _element;
        readonly TextParser _separator;
        readonly TextParser _terminator;

        public SplitWithTerminatorParser(TextParser element, TextParser separator, TextParser terminator)
        {
            _element = element;
            _separator = separator;
            _terminator = terminator;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.IsEmpty)
                return new Unmatched<TextSpan, TextSpan>(span);

            var next = span;

            var element = _element.Parse(text, span);
            if (element.HasResult)
            {
                var terminator = _terminator.Parse(text, element.Next);
                if (terminator.HasResult)
                    return new Success<TextSpan, TextSpan>(element.Result, terminator.Next);

                var separator = _separator.Parse(text, element.Next);
                if (separator.HasResult)
                    return new Success<TextSpan, TextSpan>(element.Result, separator.Next);

                if (element.Next == next)
                    return new Unmatched<TextSpan, TextSpan>(next);

                return element;
            }

            return new Unmatched<TextSpan, TextSpan>(element.Next);
        }
    }
}