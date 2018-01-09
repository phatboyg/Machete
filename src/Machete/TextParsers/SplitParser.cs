namespace Machete.TextParsers
{
    public class SplitParser :
        ITextParser
    {
        readonly ITextParser _element;
        readonly ITextParser _separator;

        public SplitParser(ITextParser element, ITextParser separator)
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
            if (!element.HasResult)
                return new Unmatched<TextSpan, TextSpan>(element.Next);
            
            var separator = _separator.Parse(text, element.Next);
            if (separator.HasResult)
                return new Success<TextSpan, TextSpan>(element.Result, separator.Next);

            if (element.Next == next)
                return new Unmatched<TextSpan, TextSpan>(next);

            return new Success<TextSpan, TextSpan>(element.Result, element.Next);
        }
    }
}