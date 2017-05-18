namespace Machete.Values.Converters
{
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
            get { return _styles; }
            set { _styles = value; }
        }

        public bool TryConvert(TextSlice slice, out Value<byte> convertedValue)
        {
            Debug.Assert(slice != null);

            byte value;
            if (byte.TryParse(slice.Text.ToString(), _styles, CultureInfo.InvariantCulture, out value))
            {
                convertedValue = new ConvertedValue<byte>(slice, value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}