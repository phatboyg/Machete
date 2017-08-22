namespace Machete.HL7.Formatters
{
    public interface HL7FormatContext
    {
        FormatLevel Level { get; }

        HL7Settings Settings { get; }
    }
}