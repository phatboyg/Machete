namespace Machete.Parsers.TextParsers
{
    using System;


    /// <summary>
    /// Matches a string constant, using the comparison type
    /// </summary>
    public class ConstantStringParser :
        TextParser
    {
        readonly StringComparison _comparisonType;
        readonly string _constant;

        public ConstantStringParser(string constant, StringComparison comparisonType = StringComparison.Ordinal)
        {
            _constant = constant;
            _comparisonType = comparisonType;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            if (span.Length >= _constant.Length)
            {
                int compareLength = span.Length > _constant.Length ? _constant.Length : span.Length;
                
                if (text.Compare(_constant, 0, new TextSpan(span.Start, compareLength), _comparisonType) == 0)
                {
                    return new Success<TextSpan, TextSpan>(new TextSpan(span.Start, compareLength), TextSpan.FromBounds(span.Start + compareLength, span.End));
                }
            }

            return new Unmatched<TextSpan, TextSpan>(span);
        }
    }
}