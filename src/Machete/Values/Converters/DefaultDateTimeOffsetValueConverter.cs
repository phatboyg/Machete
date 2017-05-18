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

            DateTimeOffset value;
            if (DateTimeOffset.TryParse(slice.Text.ToString(), CultureInfo.InvariantCulture, Styles, out value))
            {
                convertedValue = new ConstantValue<DateTimeOffset>(value);
                return true;
            }

            convertedValue = Value.Empty<DateTimeOffset>();
            return false;
        }
    }
}