namespace Machete.Values.Converters
{
    using System.Diagnostics;
    using System.Globalization;


    public class LongValueConverter :
        IValueConverter<long>
    {
        NumberStyles _styles;

        public LongValueConverter()
        {
            _styles = NumberStyles.Any;
        }

        public NumberStyles Styles
        {
            get { return _styles; }
            set { _styles = value; }
        }

        public bool TryConvert(TextSlice slice, out Value<long> convertedValue)
        {
            Debug.Assert(slice != null);

            long value;
            if (long.TryParse(slice.Text.ToString(), _styles, CultureInfo.InvariantCulture, out value))
            {
                convertedValue = new ConvertedValue<long>(value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}