namespace Machete.Values.Converters
{
    using System.Diagnostics;


    public class StringValueConverter :
        IValueConverter<string>
    {
        public bool TryConvert(TextSlice slice, out Value<string> convertedValue)
        {
            Debug.Assert(slice != null);

            string text = slice.Text.ToString();

            convertedValue = new ConvertedValue<string>(slice, text, text?.Length > 0);
            return true;
        }
    }
}