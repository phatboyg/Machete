namespace Machete.TextParsers
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
            int longest = span.Start;
            Result<TextSpan, TextSpan> result = new Unmatched<TextSpan, TextSpan>(span);
            for (int index = 0; index < _parsers.Length; index++)
            {
                var parsed = _parsers[index].Parse(text, span);
                if (parsed.HasResult && parsed.Next.Start > longest)
                    result = parsed;
            }

            return result;
        }
    }
}