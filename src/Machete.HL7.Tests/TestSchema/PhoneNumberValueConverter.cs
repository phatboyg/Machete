namespace Machete.HL7.Tests.TestSchema
{
    using System.Diagnostics;
    using Machete.Values;


    public class PhoneNumberValueConverter :
        IValueConverter<string>
    {
        public bool TryConvert(TextSlice slice, out Value<string> convertedValue)
        {
            Debug.Assert(slice != null);

            var text = slice.Text.ToString();

            if (text.Length < 10)
            {
                convertedValue = Value.Invalid<string>(slice);
                return false;
            }
                
            string phone = $"({text.Substring(0, 3)}) {text.Substring(3, 3)}-{text.Substring(6, 4)}";
                
            convertedValue = new ConvertedValue<string>(slice.SourceText, slice.SourceSpan, phone);
            return true;
        }
    }
}