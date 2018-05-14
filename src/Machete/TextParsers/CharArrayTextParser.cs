namespace Machete.TextParsers
{
    using System;


    public class CharArrayTextParser :
        ITextParser
    {
        readonly char[] _chars;
        readonly ITextParser _parser;

        public CharArrayTextParser(ITextParser parser, char[] chars)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _chars = chars ?? throw new ArgumentNullException(nameof(chars));
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var next = span;

            var matched = next.Head;
            int patternIndex;
            for (patternIndex = 0; patternIndex < _chars.Length; patternIndex++)
            {
                var parsed = _parser.Parse(text, next);
                
                if (!parsed.HasResult)
                    continue;
                
                if (next == parsed.Next)
                    break;

                var result = parsed.Result;
                
                for (int sourceIndex = result.Start; sourceIndex < parsed.Result.End; sourceIndex++, patternIndex++)
                {
                    if (!matched.IsAdjacentTo(result))
                        break;

                    if (_chars[patternIndex] != text[sourceIndex])
                        return new Unmatched<TextSpan, TextSpan>(TextSpan.FromBounds(sourceIndex, result.End));

                    matched += result;
                }

                next = parsed.Next;
            }

            if (matched.Length == _chars.Length)
                return new Success<TextSpan, TextSpan>(matched, next);

            return new Unmatched<TextSpan, TextSpan>(next);
        }
    }
}