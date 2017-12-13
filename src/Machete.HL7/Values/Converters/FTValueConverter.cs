namespace Machete.HL7.Values.Converters
{
    using System.Diagnostics;
    using Machete.Values;


    public class FTValueConverter : 
        IValueConverter<FT>
    {
        public bool TryConvert(TextSlice slice, out Value<FT> convertedValue)
        {
            Debug.Assert(slice != null);

            string text = slice.Text.ToString();

            convertedValue = new ConvertedValue<FT>(slice.SourceText, slice.SourceSpan, text, text?.Length > 0);
            return true;
            
        }
    }
}