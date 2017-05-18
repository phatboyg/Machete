namespace Machete.Parsers.TextParsers
{
    public class LongestParser :
        TextParser
    {
        readonly TextParser[] _parsers;

        public LongestParser(TextParser[] parsers)
        {
            _parsers = parsers;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            int longestStart = span.Start;
            Result<TextSpan, TextSpan> longestResult = new Unmatched<TextSpan, TextSpan>(span);
            for (int index = 0; index < _parsers.Length; index++)
            {
                var result = _parsers[index].Parse(text, span);
                if (result.HasValue && result.Next.Start > longestStart)
                    longestResult = result;
            }

            return longestResult;
        }
    }
}