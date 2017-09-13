namespace Machete.Parsers.TextParsers
{
    public class CharArrayTextParser :
        TextParser
    {
        readonly char[] _chars;
        readonly TextParser _parser;

        public CharArrayTextParser(TextParser parser, char[] chars)
        {
            _parser = parser;
            _chars = chars;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var next = span;

            var matched = next.Head;
            int i;
            for (i = 0; i < _chars.Length; i++)
            {
                var result = _parser.Parse(text, next);
                if (result.HasValue)
                {
                    if (next == result.Next)
                        break;

                    if (!matched.IsAdjacentTo(result.Value))
                        break;

                    if (_chars[i] != text[result.Value.Start])
                        break;

                    matched += result.Value;

                    next = result.Next;
                }
            }

            if (matched.Length == _chars.Length)
                return new Success<TextSpan, TextSpan>(matched, next);

            return new Unmatched<TextSpan, TextSpan>(next);
        }
    }
}