namespace Machete.Values.Converters
{
    using System.Diagnostics;


    public class BooleanValueConverter :
        IValueConverter<bool>
    {
        public bool TryConvert(TextSlice slice, out Value<bool> convertedValue)
        {
            Debug.Assert(slice != null);

            if (bool.TryParse(slice.Text.ToString(), out var value))
            {
                convertedValue = new ConvertedValue<bool>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = Value.Empty<bool>();
            return false;
        }
    }
}