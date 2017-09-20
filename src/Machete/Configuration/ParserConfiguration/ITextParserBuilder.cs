namespace Machete.ParserConfiguration
{
    public interface ITextParserBuilder :
        TextParser
    {
        TextParser Any { get; }
        TextParser Char { get; }
    }
}