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

            Styles = DateTimeStyles.AssumeUniversal | DateTimeStyles.AllowInnerWhite;
        }

        public DateTimeStyles Styles { get; set; }

        public bool TryConvert(TextSlice slice, out Value<DateTime> convertedValue)
        {
            Debug.Assert(slice != null);

            DateTime value;
            if (DateTime.TryParseExact(slice.Text.ToString(), _patterns, CultureInfo.InvariantCulture, Styles, out value))
            {
                convertedValue = new ConstantValue<DateTime>(value);
                return true;
            }

            convertedValue = Value.Empty<DateTime>();
            return false;
        }
    }
}