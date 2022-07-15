namespace Machete.HL7.Values.Converters
{
    using System;
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

        public bool TryConvert(ReadOnlySpan<char> span, out Value<FT> convertedValue)
        {
            var stringValue = new StringSpanValue(span);

            convertedValue = new SpanValue<FT>(stringValue.Value, stringValue.HasValue);
            return true;
        }
    }
}