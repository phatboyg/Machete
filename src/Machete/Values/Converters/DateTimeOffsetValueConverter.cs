namespace Machete.Values.Converters
{
    using System;
    using System.Globalization;


    public class DateTimeOffsetValueConverter :
        IValueConverter<DateTimeOffset>
    {
        readonly string[] _patterns;

        public DateTimeOffsetValueConverter(params string[] patterns)
        {
            _patterns = patterns;

            Styles = DateTimeStyles.AssumeLocal | DateTimeStyles.AllowInnerWhite;
        }

        public DateTimeStyles Styles { get; set; }

        public bool TryConvert(TextSlice slice, out Value<DateTimeOffset> convertedValue)
        {
            if (slice == null)
            {
                convertedValue = Value.Missing<DateTimeOffset>();
                return false;
            }

            DateTimeOffset value;
            if (DateTimeOffset.TryParseExact(slice.Text.ToString(), _patterns, CultureInfo.InvariantCulture, Styles, out value))
            {
                convertedValue = new ConstantValue<DateTimeOffset>(value);
                return true;
            }

            convertedValue = Value.Empty<DateTimeOffset>();
            return false;
        }
    }
}