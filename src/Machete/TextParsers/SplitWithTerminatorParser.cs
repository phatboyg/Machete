namespace Machete.TextParsers
{
    using System;


    public class SplitWithTerminatorParser :
        ITextParser
    {
        readonly ITextParser _element;
        readonly ITextParser _separator;
        readonly ITextParser _terminator;

        public SplitWithTerminatorParser(ITextParser element, ITextParser separator, ITextParser terminator)
        {
            _element = element ?? throw new ArgumentNullException(nameof(element));
            _separator = separator ?? throw new ArgumentNullException(nameof(separator));
            _terminator = terminator ?? throw new ArgumentNullException(nameof(terminator));
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.IsEmpty)
                return new Unmatched<TextSpan, TextSpan>(span);

            var next = span;

            var element = _element.Parse(text, span);
            if (!element.HasResult)
                return new Unmatched<TextSpan, TextSpan>(element.Next);
            
            var terminator = _terminator.Parse(text, element.Next);
            if (terminator.HasResult)
                return new Success<TextSpan, TextSpan>(element.Result, terminator.Next);

            var separator = _separator.Parse(text, element.Next);
            if (separator.HasResult)
                return new Success<TextSpan, TextSpan>(element.Result, separator.Next);

            return element.Next == next ? new Unmatched<TextSpan, TextSpan>(next) : element;
        }
    }
}