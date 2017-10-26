namespace Machete.HL7.Parsers
{
    using TextParsers;


    /// <summary>
    /// Parses an HL7 message from the input text, separating in the case of multiple messages in the same body
    /// </summary>
    public class HL7MessageParser :
        TextParser
    {
        static readonly LineTextParser _lineParser = new LineTextParser();

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var firstLine = _lineParser.Parse(text, span);
            if (!firstLine.HasResult)
                return new Unmatched<TextSpan, TextSpan>(span);

            var firstValue = firstLine.Result;
            if (firstValue.Length == 0)
                return new Unmatched<TextSpan, TextSpan>(span);
//                throw new MacheteParserException("The body was empty");

            if (firstValue.Length < 8)
                return new Unmatched<TextSpan, TextSpan>(span);
//                throw new MacheteParserException("The body must contain at least 8 characters");

            var firstStart = firstValue.Start;
            if (text[firstStart + 0] != 'M' || text[firstStart + 1] != 'S' || text[firstStart + 2] != 'H')
                return new Unmatched<TextSpan, TextSpan>(span);
//                throw new MacheteParserException("The body must start with an MSH segment");

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