namespace Machete.HL7
{
    using Machete.Formatters;
    using Values.Converters;


    public static class HL7ValueFormatters
    {
        public static readonly IValueFormatter<FT> FT = new FTValueFormatter();
        public static readonly IValueFormatter<TX> TX = new TXValueFormatter();

    }
}