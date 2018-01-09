namespace Machete.TextParsers
{
    /// <summary>
    /// Parses a result, returning the first element if it exists, otherwise, it will return the specified default result
    /// </summary>
    public class FirstOrDefaultTextParser :
        ITextParser
    {
        readonly ITextParser _parser;
        readonly TextSpan _defaultValue;

        public FirstOrDefaultTextParser(ITextParser parser, TextSpan defaultValue = default(TextSpan))
        {
            _parser = parser;
            _defaultValue = defaultValue;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var parsed = _parser.Parse(text, span);
            
            return parsed.HasResult ? parsed : new Success<TextSpan, TextSpan>(_defaultValue, span);
        }
    }
}