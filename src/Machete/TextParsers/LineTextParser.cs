namespace Machete.TextParsers
{
    using System;


    /// <summary>
    /// Parses lines out of text, separating on \r, \n, or \r\n automatically.
    /// </summary>
    public class LineTextParser :
        ITextParser
    {
        Func<char, bool> _isWhiteSpace;

        public LineTextParser()
        {
            _isWhiteSpace = char.IsWhiteSpace;
        }

        /// <summary>
        /// Specify the whitespace delegate for the line parser, which trims
        /// the start/end of the line.
        /// </summary>
        public Func<char, bool> IsWhiteSpace
        {
            set => _isWhiteSpace = value ?? NoWhiteSpace;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.IsEmpty)
                return new Unmatched<TextSpan, TextSpan>(span);

            int offset = span.Start;
            for (; offset < span.End && _isWhiteSpace(text[offset]); offset++) { }

            int start = offset;
            for (; offset < span.End; offset++)
            {
                char c = text[offset];
                if (c == '\r' || c == '\n')
                {
                    offset++;
                    if (c == '\r' && offset < span.End && text[offset] == '\n')
                        offset++;

                    break;
                }
            }

            int end = offset;
            for (; end > start && _isWhiteSpace(text[end - 1]); end--) { }

            if (end > span.Start)
                return new Success<TextSpan, TextSpan>(TextSpan.FromBounds(start, end), TextSpan.FromBounds(offset, span.End));

            return new Unmatched<TextSpan, TextSpan>(TextSpan.FromBounds(offset, span.End));
        }

        static bool NoWhiteSpace(char c)
        {
            return false;
        }
    }
}