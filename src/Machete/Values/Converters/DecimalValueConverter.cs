namespace Machete.Values.Converters
{
    using System.Diagnostics;
    using System.Globalization;


    public class DecimalValueConverter :
        IValueConverter<decimal>
    {
        NumberStyles _styles;

        public DecimalValueConverter()
        {
            _styles = NumberStyles.Any;
        }

        public NumberStyles Styles
        {
            get { return _styles; }
            set { _styles = value; }
        }

        public bool TryConvert(TextSlice slice, out Value<decimal> convertedValue)
        {
            Debug.Assert(slice != null);

            decimal value;
            if (decimal.TryParse(slice.Text.ToString(), _styles, CultureInfo.InvariantCulture, out value))
            {
                convertedValue = new ConvertedValue<decimal>(slice, value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}