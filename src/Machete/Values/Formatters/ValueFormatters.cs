namespace Machete.Values.Formatters
{
    using System;


    public static class ValueFormatters
    {
        public static readonly IValueFormatter<string> String = new StringValueFormatter();
        public static readonly IValueFormatter<byte> Byte = new FormatValueFormatter<byte>("D");
        public static readonly IValueFormatter<short> Short = new FormatValueFormatter<short>("D");
        public static readonly IValueFormatter<int> Int = new FormatValueFormatter<int>("D");
        public static readonly IValueFormatter<long> Long = new FormatValueFormatter<long>("D");
        public static readonly IValueFormatter<decimal> Decimal = new FormatValueFormatter<decimal>("F2");
        public static readonly IValueFormatter<Guid> Guid = new FormatValueFormatter<Guid>("N");
        public static readonly IValueFormatter<DateTime> DateTime = new DateTimeValueFormatter();
        public static readonly IValueFormatter<DateTimeOffset> DateTimeOffset = new DateTimeOffsetValueFormatter();
        public static readonly IValueFormatter<bool> Boolean = new BooleanValueFormatter();
    }
}