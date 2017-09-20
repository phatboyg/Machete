namespace Machete.TextParsers
{
    using System;


    /// <summary>
    /// Parses the input text, matching on the entire string
    /// </summary>
    public class StringTextParser :
        TextParser
    {
        readonly StringComparison _comparisonType;
        readonly string _match;

        public StringTextParser(string match, StringComparison comparisonType = StringComparison.Ordinal)
        {
            _match = match;
            _comparisonType = comparisonType;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.Length >= _match.Length)
            {
                var compareSpan = span.Take(_match.Length);

                if (text.Compare(_match, 0, compareSpan, _comparisonType) == 0)
                {
                    return new Success<TextSpan, TextSpan>(compareSpan, span.Skip(_match.Length));
                }
            }

            return new Unmatched<TextSpan, TextSpan>(span);
        }
    }
}