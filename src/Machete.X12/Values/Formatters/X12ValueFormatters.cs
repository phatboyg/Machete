namespace Machete.X12.Values.Formatters
{
    public static class X12ValueFormatters
    {
        public static readonly IValueFormatter<DateTimePeriod> DateTimePeriod = new DateTimePeriodValueFormatter();
    }
}