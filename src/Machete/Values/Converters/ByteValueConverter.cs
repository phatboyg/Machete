namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class ByteValueConverter :
        IValueConverter<byte>
    {
        NumberStyles _styles;

        public ByteValueConverter()
        {
            _styles = NumberStyles.Any;
        }

        public NumberStyles Styles
        {
            get => _styles;
            set => _styles = value;
        }

        public bool TryConvert(TextSlice slice, out Value<byte> convertedValue)
        {
            Debug.Assert(slice != null);

            if (byte.TryParse(slice.Text.ToString(), _styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new ConvertedValue<byte>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = null;
            return false;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<byte> convertedValue)
        {
            if (byte.TryParse(span, Styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new SpanValue<byte>(value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}