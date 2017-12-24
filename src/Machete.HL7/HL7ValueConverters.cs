namespace Machete.HL7
{
    using System;
    using Machete.Values.Converters;
    using Values.Converters;


    public static class HL7ValueConverters
    {
        static readonly string[] _longDateTimePatterns = {
            "yyyyMMddHHmmssffffffzzz",
            "yyyyMMddHHmmssffffffzz",
            "yyyyMMddHHmmssffffffz",
            "yyyyMMddHHmmssfffffzzz",
            "yyyyMMddHHmmssfffffzz",
            "yyyyMMddHHmmssfffffz",
            "yyyyMMddHHmmssffffzzz",
            "yyyyMMddHHmmssffffzz",
            "yyyyMMddHHmmssffffz",
            "yyyyMMddHHmmssfffzzz",
            "yyyyMMddHHmmssfffzz",
            "yyyyMMddHHmmssfffz",
            "yyyyMMddHHmmssffzzz",
            "yyyyMMddHHmmssffzz",
            "yyyyMMddHHmmssffz",
            "yyyyMMddHHmmssfzzz",
            "yyyyMMddHHmmssfzz",
            "yyyyMMddHHmmssfz",
            "yyyyMMddHHmmssffffff",
            "yyyyMMddHHmmssfffff",
            "yyyyMMddHHmmssffff",
            "yyyyMMddHHmmssfff",
            "yyyyMMddHHmmssff",
            "yyyyMMddHHmmssf",
            "yyyyMMddHHmmsszzz",
            "yyyyMMddHHmmsszz",
            "yyyyMMddHHmmssz",
            "yyyyMMddHHmmss.ffffffzzz",
            "yyyyMMddHHmmss.ffffffzz",
            "yyyyMMddHHmmss.ffffffz",
            "yyyyMMddHHmmss.fffffzzz",
            "yyyyMMddHHmmss.fffffzz",
            "yyyyMMddHHmmss.fffffz",
            "yyyyMMddHHmmss.ffffzzz",
            "yyyyMMddHHmmss.ffffzz",
            "yyyyMMddHHmmss.ffffz",
            "yyyyMMddHHmmss.fffzzz",
            "yyyyMMddHHmmss.fffzz",
            "yyyyMMddHHmmss.fffz",
            "yyyyMMddHHmmss.ffzzz",
            "yyyyMMddHHmmss.ffzz",
            "yyyyMMddHHmmss.ffz",
            "yyyyMMddHHmmss.fzzz",
            "yyyyMMddHHmmss.fzz",
            "yyyyMMddHHmmss.fz",
            "yyyyMMddHHmmss.ffffff",
            "yyyyMMddHHmmss.fffff",
            "yyyyMMddHHmmss.ffff",
            "yyyyMMddHHmmss.fff",
            "yyyyMMddHHmmss.ff",
            "yyyyMMddHHmmss.f",
            "yyyyMMddHHmmss",
            "yyyyMMddHHmms",
            "yyyyMMddHHmmzzz",
            "yyyyMMddHHmmzz",
            "yyyyMMddHHmmz",
            "yyyyMMddHH",
            "yyyyMMddHHmm",
            "yyyyMMddHHm",
            "yyyyMMddHHzzz",
            "yyyyMMddHHzz",
            "yyyyMMddHHz",
            "yyyyMMddzzz",
            "yyyyMMddzz",
            "yyyyMMddz",
            "yyyyMMdd",
            "yyyyMMdz",
            "yyyyMMd",
            "yyyyMMzzz",
            "yyyyMMzz",
            "yyyyMMz",
            "yyyyMM",
            "yyyyM",
            "yyyy"
        };
        
        static readonly string[] _shortDateTimePatterns = {
            "yyyyMMddHHmmssffffff",
            "yyyyMMddHHmmssfffff",
            "yyyyMMddHHmmssffff",
            "yyyyMMddHHmmssfff",
            "yyyyMMddHHmmssff",
            "yyyyMMddHHmmssf",
            "yyyyMMddHHmmss.ffffff",
            "yyyyMMddHHmmss.fffff",
            "yyyyMMddHHmmss.ffff",
            "yyyyMMddHHmmss.fff",
            "yyyyMMddHHmmss.ff",
            "yyyyMMddHHmmss.f",
            "yyyyMMddHHmmss",
            "yyyyMMddHHmms",
            "yyyyMMddHH",
            "yyyyMMddHHmm",
            "yyyyMMddHHm",
            "yyyyMMdd",
            "yyyyMMdz",
            "yyyyMMd",
            "yyyyMM",
            "yyyyM",
            "yyyy"
        };

        public static readonly IValueConverter<DateTimeOffset> VariableLongDateTime;
        public static readonly IValueConverter<DateTime> VairableShortDateTime;

        public static readonly IValueConverter<FT> FT = new FTValueConverter();
        public static readonly IValueConverter<TX> TX = new TXValueConverter();

        static HL7ValueConverters()
        {
            VariableLongDateTime = new DateTimeOffsetValueConverter(_longDateTimePatterns);
            VairableShortDateTime = new DateTimeValueConverter(_shortDateTimePatterns);
        }
    }
}