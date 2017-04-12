namespace Machete.Values.Converters
{
    public class StringValueConverter :
        IValueConverter<string>
    {
        public bool TryConvert(TextSlice slice, out Value<string> convertedValue)
        {
            string text = slice.Text.ToString();

            convertedValue = new ConvertedValue<string>(slice, text);
            return true;
        }
    }
}