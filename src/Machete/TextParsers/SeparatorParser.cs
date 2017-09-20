namespace Machete.TextParsers
{
    using System;


    public class SeparatorParser :
        TextParser
    {
        readonly Func<char, bool> _isWhiteSpace;
        readonly char _separator;

        public SeparatorParser(char separator)
        {
            _separator = separator;
            _isWhiteSpace = char.IsWhiteSpace;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.IsEmpty)
                return new Unmatched<TextSpan, TextSpan>(span);

            var offset = span.Start;
            for (; offset < span.End && _isWhiteSpace(text[offset]); offset++)
            {
            }

            var start = offset;
            for (; offset < span.End; offset++)
            {
                var c = text[offset];
                if (c == _separator)
                    break;
            }

            var end = offset;
            for (; end > start && _isWhiteSpace(text[end - 1]); end--)
            {
            }

            return new Success<TextSpan, TextSpan>(TextSpan.FromBounds(start, end),
                offset < span.End ? TextSpan.FromBounds(offset + 1, span.End) : new TextSpan(span.End, 0));
        }

        public override string ToString()
        {
            return $"SeparatorParser({_separator})";
        }
    }
}