namespace Machete.TextParsers
{
    using System;


    /// <summary>
    /// Parses the input text, matching on the entire string
    /// </summary>
    public class StringTextParser :
        ITextParser
    {
        readonly StringComparison _comparisonType;
        readonly string _match;
        readonly ITextParser _parser;

        public StringTextParser(ITextParser parser, string match, StringComparison comparisonType = StringComparison.Ordinal)
        {
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
            _match = match ?? throw new ArgumentNullException(nameof(match));
            _comparisonType = comparisonType;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var parsed = _parser.Parse(text, span);
            if (!parsed.HasResult)
                return new Unmatched<TextSpan, TextSpan>(parsed.Next);
            
            var result = parsed.Result;

            if (result.Length < _match.Length)
                return new Unmatched<TextSpan, TextSpan>(parsed.Next);
            
            var compareSpan = result.Take(_match.Length);

            if (text.Compare(_match, 0, compareSpan, _comparisonType) == 0)
                return new Success<TextSpan, TextSpan>(compareSpan, result.Skip(_match.Length) + parsed.Next);

            return new Unmatched<TextSpan, TextSpan>(parsed.Next);
        }
    }
}