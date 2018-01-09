namespace Machete.TextParsers
{
    using System;


    public class SymbolTextParser :
        ITextParser
    {
        readonly Func<char, bool> _firstCharacter;
        readonly Func<char, bool> _nextCharacter;

        public SymbolTextParser(Func<char, bool> firstCharacter, Func<char, bool> nextCharacter)
        {
            _firstCharacter = firstCharacter ?? throw new ArgumentNullException(nameof(firstCharacter));
            _nextCharacter = nextCharacter ?? throw new ArgumentNullException(nameof(nextCharacter));
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
                return new Success<TextSpan, TextSpan>(span.Take(offset), span.Skip(offset));

            return new Unmatched<TextSpan, TextSpan>(span.Skip(offset));
        }
    }
}