namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class DecimalValueConverter :
        IValueConverter<decimal>
    {
        public DecimalValueConverter()
        {
            Styles = NumberStyles.Any;
        }

        public NumberStyles Styles { get; set; }

        public bool TryConvert(TextSlice slice, out Value<decimal> convertedValue)
        {
            Debug.Assert(slice != null);

            if (decimal.TryParse(slice.Text.ToString(), Styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new ConvertedValue<decimal>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = null;
            return false;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<decimal> convertedValue)
        {
            if (decimal.TryParse(span, Styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new SpanValue<decimal>(value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}