namespace Machete.HL7.Formatters
{
    public class HL7FormatterSettings :
        HL7Settings
    {
        public HL7FormatterSettings()
        {
            FieldSeparator = '|';
            ComponentSeparator = '^';
            RepetitionSeparator = '~';
            SubComponentSeparator = '&';
            EscapeCharacter = '\\';
            SegmentSeparator = '\r';
        }

        public char FieldSeparator { get; }
        public char ComponentSeparator { get; }
        public char RepetitionSeparator { get; }
        public char SubComponentSeparator { get; }
        public char EscapeCharacter { get; }

        public char SegmentSeparator { get; }
    }
}