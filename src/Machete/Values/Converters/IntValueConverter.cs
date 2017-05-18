namespace Machete.Values.Converters
{
    using System.Diagnostics;
    using System.Globalization;


    public class IntValueConverter :
        IValueConverter<int>
    {
        NumberStyles _styles;

        public IntValueConverter()
        {
            _styles = NumberStyles.Any;
        }

        public NumberStyles Styles
        {
            get { return _styles; }
            set { _styles = value; }
        }

        public bool TryConvert(TextSlice slice, out Value<int> convertedValue)
        {
            Debug.Assert(slice != null);

            int value;
            if (int.TryParse(slice.Text.ToString(), _styles, CultureInfo.InvariantCulture, out value))
            {
                convertedValue = new ConvertedValue<int>(slice, value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}