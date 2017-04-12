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
        public static readonly IValueConverter<DateTimeOffset> DateTimeOffset = new DateTimeOffsetValueConverter();
        public static readonly IValueConverter<DateTime> DateTime = new DateTimeValueConverter();
    }
}