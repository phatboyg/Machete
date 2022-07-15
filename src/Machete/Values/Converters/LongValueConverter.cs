namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class LongValueConverter :
        IValueConverter<long>
    {
        public LongValueConverter()
        {
            Styles = NumberStyles.Any;
        }

        public NumberStyles Styles { get; set; }

        public bool TryConvert(TextSlice slice, out Value<long> convertedValue)
        {
            Debug.Assert(slice != null);

            if (long.TryParse(slice.Text.ToString(), Styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new ConvertedValue<long>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = null;
            return false;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<long> convertedValue)
        {
            if (long.TryParse(span, Styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new SpanValue<long>(value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}