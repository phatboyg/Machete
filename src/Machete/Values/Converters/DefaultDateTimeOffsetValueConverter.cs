namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class DefaultDateTimeOffsetValueConverter :
        IValueConverter<DateTimeOffset>
    {
        public DefaultDateTimeOffsetValueConverter()
        {
            Styles = DateTimeStyles.AssumeUniversal | DateTimeStyles.AllowInnerWhite;
        }

        public DateTimeStyles Styles { get; set; }

        public bool TryConvert(TextSlice slice, out Value<DateTimeOffset> convertedValue)
        {
            Debug.Assert(slice != null);

            if (DateTimeOffset.TryParse(slice.Text.ToString(), CultureInfo.InvariantCulture, Styles, out var value))
            {
                convertedValue = new ConvertedValue<DateTimeOffset>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = Value.Empty<DateTimeOffset>();
            return false;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<DateTimeOffset> convertedValue)
        {
            if (DateTimeOffset.TryParse(span, CultureInfo.InvariantCulture, Styles, out var value))
            {
                convertedValue = new SpanValue<DateTimeOffset>(value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}