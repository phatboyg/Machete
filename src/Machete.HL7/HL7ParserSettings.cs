namespace Machete.HL7
{
    public interface HL7ParserSettings :
        HL7Settings
    {
        TextParser FieldParser { get; }
        TextParser ComponentParser { get; }
        TextParser SubComponentParser { get; }
        TextParser RepetitionParser { get; }
        TextParser TextParser { get; }
    }
}