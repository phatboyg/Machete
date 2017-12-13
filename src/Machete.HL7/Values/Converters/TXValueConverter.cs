namespace Machete.HL7.Values.Converters
{
    using System.Diagnostics;
    using Machete.Values;


    public class TXValueConverter :
        IValueConverter<TX>
    {
        public bool TryConvert(TextSlice slice, out Value<TX> convertedValue)
        {
            Debug.Assert(slice != null);

            string text = slice.Text.ToString();

            convertedValue = new ConvertedValue<TX>(text, text?.Length > 0);
            return true;
        }
    }
}