namespace Machete.TextParsers
{
    using System;


    public class SeriesTextParser :
        ITextParser
    {
        readonly ITextParser _parser;
        readonly bool _atLeastOne;

        public SeriesTextParser(ITextParser parser, bool atLeastOne)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _atLeastOne = atLeastOne;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var next = span;

            var parsed = _parser.Parse(text, span);
            if (_atLeastOne && !parsed.HasResult)
                return new Unmatched<TextSpan, TextSpan>(parsed.Next);

            var matched = parsed.Result.Head;

            while (parsed.HasResult)
            {
                if (next == parsed.Next)
                    break;

                if (!matched.IsAdjacentTo(parsed.Result))
                    break;

                matched += parsed.Result;

                next = parsed.Next;

                parsed = _parser.Parse(text, next);
            }

            return new Success<TextSpan, TextSpan>(matched, next);
        }
    }
}