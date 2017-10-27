namespace Machete.ParserConfiguration
{
    public interface ITextParserBuilder :
        ITextParser
    {
        ITextParser Any { get; }
        ITextParser Char { get; }
    }
}