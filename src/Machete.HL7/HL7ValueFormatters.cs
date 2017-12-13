namespace Machete.HL7
{
    using System;
    using Values.Formatters;


    public static class HL7ValueFormatters
    {
        public static readonly IValueFormatter<FT> FT = new FTValueFormatter();
        public static readonly IValueFormatter<TX> TX = new TXValueFormatter();
        public static readonly IValueFormatter<DateTimeOffset> LongDateTimeOffset = new LongDateTimeOffsetValueFormatter();
    }
}