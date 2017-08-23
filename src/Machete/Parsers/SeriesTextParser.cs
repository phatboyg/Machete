namespace Machete.Parsers
{
    public class SeriesTextParser :
        TextParser
    {
        readonly TextParser _parser;

        public SeriesTextParser(TextParser parser)
        {
            _parser = parser;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var next = span;

            var result = _parser.Parse(text, span);
            if (!result.HasValue)
                return new Unmatched<TextSpan, TextSpan>(span);

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