namespace Machete.TextParsers
{
    /// <summary>
    /// Parses uses the specified parser only if the except parser is unsuccessful
    /// </summary>
    public class ExceptTextParser :
        TextParser
    {
        readonly TextParser _except;
        readonly TextParser _parser;

        public ExceptTextParser(TextParser parser, TextParser except)
        {
            _parser = parser;
            _except = except;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            var parsed = _except.Parse(text, span);
            if (parsed.HasResult)
                return new Unmatched<TextSpan, TextSpan>(span);

            return _parser.Parse(text, span);
        }
    }
}