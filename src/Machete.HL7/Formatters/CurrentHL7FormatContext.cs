namespace Machete.HL7.Formatters
{
    public class CurrentHL7FormatContext :
        HL7FormatContext
    {
        public CurrentHL7FormatContext(FormatLevel level)
        {
            Level = level;
        }

        public FormatLevel Level { get; }
    }
}