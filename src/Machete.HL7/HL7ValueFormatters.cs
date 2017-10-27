namespace Machete.HL7
{
    using Values.Converters;
    using Values.Formatters;


    public static class HL7ValueFormatters
    {
        public static readonly IValueFormatter<FT> FT = new FTValueFormatter();
        public static readonly IValueFormatter<TX> TX = new TXValueFormatter();
    }
}