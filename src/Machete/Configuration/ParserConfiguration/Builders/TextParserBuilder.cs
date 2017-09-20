namespace Machete.ParserConfiguration.Builders
{
    using TextParsers;


    public class TextParserBuilder :
        ITextParserBuilder
    {
        readonly TextParser _any;

        public TextParserBuilder()
        {
            _any = new AnyTextParser();
        }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            return _any.Parse(text, span);
        }
    }
}