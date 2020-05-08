namespace Machete.X12.Values.Converters
{
    using System.Diagnostics;
    using Machete.Values;


    public class DateTimePeriodValueConverter :
        IValueConverter<DateTimePeriod>
    {
        public bool TryConvert(TextSlice slice, out Value<DateTimePeriod> convertedValue)
        {
            Debug.Assert(slice != null);

            string text = slice.Text.ToString();

            convertedValue = new ConvertedValue<DateTimePeriod>(slice.SourceText, slice.SourceSpan, text, text?.Length > 0);
            return true;
        }
    }
}