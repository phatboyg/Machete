namespace Machete.Values.Converters
{
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
            long value;
            if (long.TryParse(slice.Text.ToString(), _styles, CultureInfo.InvariantCulture, out value))
            {
                convertedValue = new ConvertedValue<long>(slice, value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}