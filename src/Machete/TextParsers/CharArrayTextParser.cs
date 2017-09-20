namespace Machete.TextParsers
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
                if (result.HasResult)
                {
                    if (next == result.Next)
                        break;

                    for (int j = result.Result.Start; j < result.Result.End; j++, i++)
                    {
                        if (!matched.IsAdjacentTo(result.Result))
                            break;

                        if (_chars[i] != text[j])
                            return new Unmatched<TextSpan, TextSpan>(TextSpan.FromBounds(j, result.Result.End));

                        matched += result.Result;
                    }

                    next = result.Next;
                }
            }

            if (matched.Length == _chars.Length)
                return new Success<TextSpan, TextSpan>(matched, next);

            return new Unmatched<TextSpan, TextSpan>(next);
        }
    }
}