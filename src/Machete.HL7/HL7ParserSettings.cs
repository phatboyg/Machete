namespace Machete.HL7
{
    public interface HL7ParserSettings :
        HL7Settings
    {
        ITextParser FieldParser { get; }
        ITextParser ComponentParser { get; }
        ITextParser SubComponentParser { get; }
        ITextParser RepetitionParser { get; }
        ITextParser TextParser { get; }
    }
}