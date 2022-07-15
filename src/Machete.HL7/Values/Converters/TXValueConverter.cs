namespace Machete.HL7.Values.Converters
{
    using System;
    using System.Diagnostics;
    using Machete.Values;


    public class TXValueConverter :
        IValueConverter<TX>
    {
        public bool TryConvert(TextSlice slice, out Value<TX> convertedValue)
        {
            Debug.Assert(slice != null);

            var text = slice.Text.ToString();

            convertedValue = new ConvertedValue<TX>(slice.SourceText, slice.SourceSpan, text, text?.Length > 0);
            return true;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<TX> convertedValue)
        {
            var stringValue = new StringSpanValue(span);

            convertedValue = new SpanValue<TX>(stringValue.Value, stringValue.HasValue);
            return true;
        }
    }
}