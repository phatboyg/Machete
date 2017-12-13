namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class DateTimeValueConverter :
        IValueConverter<DateTime>
    {
        readonly string[] _patterns;

        public DateTimeValueConverter(params string[] patterns)
        {
            _patterns = patterns;

            Styles = DateTimeStyles.AllowInnerWhite;
        }

        public DateTimeStyles Styles { get; set; }

        public bool TryConvert(TextSlice slice, out Value<DateTime> convertedValue)
        {
            Debug.Assert(slice != null);

            var text = slice.Text.ToString();
            if (DateTime.TryParseExact(text, _patterns, CultureInfo.InvariantCulture, Styles, out var value))
            {
                convertedValue = new ConvertedValue<DateTime>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = Value.Empty<DateTime>();
            return false;
        }
    }
}