namespace Machete.Parsers.TextParsers
{
    public class SeriesTextParser :
        TextParser
    {
        readonly TextParser _parser;
        readonly bool _atLeastOne;

        public SeriesTextParser(TextParser parser, bool atLeastOne)
        {
            _parser = parser;
            _atLeastOne = atLeastOne;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var next = span;

            var result = _parser.Parse(text, span);
            if (_atLeastOne && !result.HasValue)
                return new Unmatched<TextSpan, TextSpan>(result.Next);

            var matched = result.Value.Head;

            while (result.HasValue)
            {
                if (next == result.Next)
                    break;

                if (!matched.IsAdjacentTo(result.Value))
                    break;

                matched += result.Value;

                next = result.Next;

                result = _parser.Parse(text, next);
            }

            return new Success<TextSpan, TextSpan>(matched, next);
        }
    }
}