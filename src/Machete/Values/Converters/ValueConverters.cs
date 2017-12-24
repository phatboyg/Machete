namespace Machete.Values.Converters
{
    using System;


    public static class ValueConverters
    {
        public static readonly IValueConverter<string> String = new StringValueConverter();
        public static readonly IValueConverter<byte> Byte = new ByteValueConverter();
        public static readonly IValueConverter<short> Short = new ShortValueConverter();
        public static readonly IValueConverter<int> Int = new IntValueConverter();
        public static readonly IValueConverter<long> Long = new LongValueConverter();
        public static readonly IValueConverter<decimal> Decimal = new DecimalValueConverter();
        public static readonly IValueConverter<Guid> Guid = new GuidValueConverter();
        public static readonly IValueConverter<DateTimeOffset> DateTimeOffset = new DefaultDateTimeOffsetValueConverter();
        public static readonly IValueConverter<DateTime> DateTime = new DateTimeValueConverter();
        public static readonly IValueConverter<bool> Boolean = new BooleanValueConverter();

        public static readonly IValueConverter<DateTime> ShortDate;
        public static readonly IValueConverter<DateTime> ShortDateTime;
        public static readonly IValueConverter<DateTime> ShortDateTimeWithSeconds;
        public static readonly IValueConverter<DateTime> LongDate;
        public static readonly IValueConverter<DateTime> LongDateTime;
        public static readonly IValueConverter<DateTime> LongDateTimeWithSeconds;
        public static readonly IValueConverter<DateTime> Time;
        public static readonly IValueConverter<DateTime> TimeWithSeconds;

        static ValueConverters()
        {
            ShortDate = new DateTimeValueConverter("yyMMdd");
            ShortDateTime = new DateTimeValueConverter("yyMMddHHmm");
            ShortDateTimeWithSeconds = new DateTimeValueConverter("yyMMddHHmmss");
            LongDate = new DateTimeValueConverter("yyyyMMdd");
            LongDateTime = new DateTimeValueConverter("yyyyMMddHHmm");
            LongDateTimeWithSeconds = new DateTimeValueConverter("yyyyMMddHHmmss");
            Time = new DateTimeValueConverter("HHmm");
            TimeWithSeconds = new DateTimeValueConverter("HHmmss");
        }
    }
}