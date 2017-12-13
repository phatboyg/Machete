namespace Machete.Values.Converters
{
    using System.Diagnostics;


    public class StringValueConverter :
        IValueConverter<string>
    {
        public bool TryConvert(TextSlice slice, out Value<string> convertedValue)
        {
            Debug.Assert(slice != null);

            convertedValue = new StringValue(slice.SourceText, slice.SourceSpan);

            return true;
        }
    }
}