namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class ShortValueConverter :
        IValueConverter<short>
    {
        public ShortValueConverter()
        {
            Styles = NumberStyles.Any;
        }

        public NumberStyles Styles { get; set; }

        public bool TryConvert(TextSlice slice, out Value<short> convertedValue)
        {
            Debug.Assert(slice != null);

            if (short.TryParse(slice.Text.ToString(), Styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new ConvertedValue<short>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = null;
            return false;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<short> convertedValue)
        {
            if (short.TryParse(span, Styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new SpanValue<short>(value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}