namespace Machete.TextParsers
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
            if (_atLeastOne && !result.HasResult)
                return new Unmatched<TextSpan, TextSpan>(result.Next);

            var matched = result.Result.Head;

            while (result.HasResult)
            {
                if (next == result.Next)
                    break;

                if (!matched.IsAdjacentTo(result.Result))
                    break;

                matched += result.Result;

                next = result.Next;

                result = _parser.Parse(text, next);
            }

            return new Success<TextSpan, TextSpan>(matched, next);
        }
    }
}