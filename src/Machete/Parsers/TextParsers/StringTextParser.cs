namespace Machete.Parsers.TextParsers
{
    using System;


    /// <summary>
    /// Parses the input text, matching on the entire string
    /// </summary>
    public class StringTextParser :
        TextParser
    {
        readonly StringComparison _comparisonType;
        readonly string _constant;

        public StringTextParser(string constant, StringComparison comparisonType = StringComparison.Ordinal)
        {
            _constant = constant;
            _comparisonType = comparisonType;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.Length >= _constant.Length)
            {
                var compareSpan = span.Take(_constant.Length);

                if (text.Compare(_constant, 0, compareSpan, _comparisonType) == 0)
                {
                    return new Success<TextSpan, TextSpan>(compareSpan, span.Skip(_constant.Length));
                }
            }

            return new Unmatched<TextSpan, TextSpan>(span);
        }
    }
}