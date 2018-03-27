namespace Machete.X12.Values.Converters
{
    using System;
    using Machete.Values.Converters;


    public static class X12ValueConverters
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
        public static readonly IValueConverter<DateTime> VariableShortDateTime;
        public static readonly IValueConverter<DateTimePeriod> DateTimePeriod = new DateTimePeriodValueConverter();

        static X12ValueConverters()
        {
            VariableLongDateTime = new DateTimeOffsetValueConverter(_longDateTimePatterns);
            VariableShortDateTime = new DateTimeValueConverter(_shortDateTimePatterns);
        }
    }
}