namespace Machete.Values.Converters
{
    using System.Globalization;


    public class ShortValueConverter :
        IValueConverter<short>
    {
        NumberStyles _styles;

        public ShortValueConverter()
        {
            _styles = NumberStyles.Any;
        }

        public NumberStyles Styles
        {
            get { return _styles; }
            set { _styles = value; }
        }

        public bool TryConvert(TextSlice slice, out Value<short> convertedValue)
        {
            short value;
            if (short.TryParse(slice.Text.ToString(), _styles, CultureInfo.InvariantCulture, out value))
            {
                convertedValue = new ConvertedValue<short>(slice, value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}