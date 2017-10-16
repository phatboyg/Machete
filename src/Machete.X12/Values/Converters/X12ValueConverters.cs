namespace Machete.X12.Values.Converters
{
    public static class X12ValueConverters
    {
        public static readonly IValueConverter<DateTimePeriod> DateTimePeriod = new DateTimePeriodValueConverter();
    }
}