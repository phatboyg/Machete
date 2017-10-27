namespace Machete.TextParsers
{
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
            if (parsed.HasResult)
                return parsed;

            return new Success<TextSpan, TextSpan>(_defaultValue, span);
        }
    }
}