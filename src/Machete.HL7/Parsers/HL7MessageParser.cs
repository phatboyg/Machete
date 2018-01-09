namespace Machete.HL7.Parsers
{
    using TextParsers;


    /// <summary>
    /// Parses an HL7 message from the input text, separating in the case of multiple messages in the same body
    /// </summary>
    public class HL7MessageParser :
        ITextParser
    {
        static readonly LineTextParser _lineParser = new LineTextParser();

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var firstLine = _lineParser.Parse(text, span);
            if (!firstLine.HasResult)
                return firstLine;

            var firstValue = firstLine.Result;
            if (firstValue.Length == 0)
                return new Unmatched<TextSpan, TextSpan>(firstLine.Next);

            if (firstValue.Length < 8)
                return new Unmatched<TextSpan, TextSpan>(firstLine.Next);

            var firstStart = firstValue.Start;
            if (text[firstStart + 0] != 'M' || text[firstStart + 1] != 'S' || text[firstStart + 2] != 'H')
                return new Unmatched<TextSpan, TextSpan>(firstLine.Next);

            var previousLine = firstLine;
            Result<TextSpan, TextSpan> nextLine;
            while ((nextLine = _lineParser.Parse(text, previousLine.Next)).HasResult)
            {
                var start = nextLine.Result.Start;
                if (nextLine.Result.Length >= 3 && text[start] == 'M' && text[start + 1] == 'S' && text[start + 2] == 'H')
                    return new Success<TextSpan, TextSpan>(TextSpan.FromBounds(firstStart, previousLine.Result.End), previousLine.Next);

                previousLine = nextLine;
            }

            var previousEnd = previousLine.Result.End;
            
            return new Success<TextSpan, TextSpan>(TextSpan.FromBounds(firstStart, previousEnd), TextSpan.FromBounds(previousEnd, span.End));
        }
    }
}