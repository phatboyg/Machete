namespace Machete.X12.Values.Formatters
{
    using Machete.Formatters;


    public static class X12ValueFormatters
    {
        public static readonly IValueFormatter<DateTimePeriod> DateTimePeriod = new DateTimePeriodValueFormatter();
    }
}