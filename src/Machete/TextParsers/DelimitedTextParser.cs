namespace Machete.TextParsers
{
    /// <summary>
    /// Parses delimited text
    /// </summary>
    public class DelimitedTextParser :
        ITextParser
    {
        readonly ITextParser _parser;

        public DelimitedTextParser(char elementSeparator)
        {
            var any = new AnyTextParser();

            var elementSeparatorParser = any.Char(elementSeparator);

            var escapeEscape = any.Chars('\\', '\\');
            var escapeQuote = any.Chars('\\', '\"');

            var validChars = any.Char(x => x != elementSeparator);

            ITextParser rawString = validChars.ZeroOrMore();

            var quotedChars = escapeEscape.Or(escapeQuote).Or(any.Char(x => x != '\"'));

            var quotedText = from open in any.Char('\"')
                from cs in quotedChars.ZeroOrMore()
                from close in any.Char('\"')
                select cs;

            var value = quotedText.Or(rawString);

            _parser = from vs in value.Split(elementSeparatorParser)
                select vs;
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            return _parser.Parse(text, span);
        }
    }
}