namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class TimeValueConverter :
        IValueConverter<TimeSpan>
    {
        readonly string[] _patterns;

        public TimeSpanStyles Styles { get; set; }

        public TimeValueConverter(params string[] patterns)
        {
            _patterns = patterns;

            Styles = TimeSpanStyles.None;
        }

        public bool TryConvert(TextSlice slice, out Value<TimeSpan> convertedValue)
        {
            Debug.Assert(slice != null);

            var text = slice.Text.ToString();
            if (TimeSpan.TryParseExact(text, _patterns, CultureInfo.InvariantCulture, Styles, out var value))
            {
                convertedValue = new ConvertedValue<TimeSpan>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = Value.Empty<TimeSpan>();
            return false;
        }
    }
}