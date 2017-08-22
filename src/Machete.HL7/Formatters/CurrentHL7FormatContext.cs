namespace Machete.HL7.Formatters
{
    public class CurrentHL7FormatContext :
        HL7FormatContext
    {
        public CurrentHL7FormatContext(HL7Settings settings)
        {
            Settings = settings;
        }

        public CurrentHL7FormatContext(FormatLevel level)
        {
            Level = level;
            Settings = new HL7FormatterSettings();
        }

        public CurrentHL7FormatContext(HL7FormatContext source, FormatLevel level)
        {
            Level = level;
            Settings = source.Settings;
        }

        public FormatLevel Level { get; }

        public HL7Settings Settings { get; }
    }
}