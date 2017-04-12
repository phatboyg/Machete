namespace Machete.Parsers
{
    using System;


    public class SymbolParser :
        TextParser
    {
        readonly Func<char, bool> _firstCharacter;
        readonly Func<char, bool> _nextCharacter;

        public SymbolParser(Func<char, bool> firstCharacter, Func<char, bool> nextCharacter)
        {
            _firstCharacter = firstCharacter;
            _nextCharacter = nextCharacter;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            int offset = span.Start;
            if (offset < span.End)
            {
                if (_firstCharacter(text[offset]))
                {
                    offset++;
                    for (; offset < span.End; offset++)
                    {
                        if (_nextCharacter(text[offset]) == false)
                            break;
                    }
                }
            }

            if (offset > span.Start)
                return new Success<TextSpan, TextSpan>(TextSpan.FromBounds(span.Start, offset), TextSpan.FromBounds(offset, span.End));

            throw new InvalidOperationException("Need a missing result for unmatched");
        }
    }
}