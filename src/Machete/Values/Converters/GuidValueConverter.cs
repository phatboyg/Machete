namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;
    using System.Globalization;


    public class GuidValueConverter :
        IValueConverter<Guid>
    {
        NumberStyles _styles;

        public GuidValueConverter()
        {
            _styles = NumberStyles.Any;
        }

        public NumberStyles Styles
        {
            get { return _styles; }
            set { _styles = value; }
        }

        public bool TryConvert(TextSlice slice, out Value<Guid> convertedValue)
        {
            Debug.Assert(slice != null);

            Guid value;
            if (Guid.TryParse(slice.Text.ToString(), out value))
            {
                convertedValue = new ConvertedValue<Guid>(slice, value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}