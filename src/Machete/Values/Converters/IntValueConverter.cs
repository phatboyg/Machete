namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class IntValueConverter :
        IValueConverter<int>
    {
        public IntValueConverter()
        {
            Styles = NumberStyles.Any;
        }

        public NumberStyles Styles { get; set; }

        public bool TryConvert(TextSlice slice, out Value<int> convertedValue)
        {
            Debug.Assert(slice != null);

            if (int.TryParse(slice.Text.ToString(), Styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new ConvertedValue<int>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }


            convertedValue = null;
            return false;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<int> convertedValue)
        {
            if (int.TryParse(span, Styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new SpanValue<int>(value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}