namespace Machete.X12.Values.Converters
{
    using System;


    public class DateTimePeriodValueConverter :
        IValueConverter<DateTimePeriod>
    {
        public bool TryConvert(TextSlice slice, out Value<DateTimePeriod> convertedValue)
        {
            throw new NotImplementedException();
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<DateTimePeriod> convertedValue)
        {
            throw new NotImplementedException();
        }
    }
}