namespace Machete.ParserConfiguration.Builders
{
    using TextParsers;


    public class TextParserBuilder :
        ITextParserBuilder
    {
        public TextParserBuilder()
        {
            Any = new AnyTextParser();
            Char = Any.Char();
        }

        public ITextParser Any { get; }
        public ITextParser Char { get; }

        public Result<TextSpan, TextSpan> Parse(ParseText text, TextSpan span)
        {
            return Any.Parse(text, span);
        }
    }
}