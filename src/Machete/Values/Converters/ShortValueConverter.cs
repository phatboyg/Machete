namespace Machete.Values.Converters
{
    using System.Diagnostics;
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
            Debug.Assert(slice != null);

            if (short.TryParse(slice.Text.ToString(), _styles, CultureInfo.InvariantCulture, out var value))
            {
                convertedValue = new ConvertedValue<short>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}