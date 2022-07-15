namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;


    public class GuidValueConverter :
        IValueConverter<Guid>
    {
        public bool TryConvert(TextSlice slice, out Value<Guid> convertedValue)
        {
            Debug.Assert(slice != null);

            if (Guid.TryParse(slice.Text.ToString(), out var value))
            {
                convertedValue = new ConvertedValue<Guid>(slice.SourceText, slice.SourceSpan, value);
                return true;
            }

            convertedValue = null;
            return false;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<Guid> convertedValue)
        {
            if (Guid.TryParse(span, out var value))
            {
                convertedValue = new SpanValue<Guid>(value);
                return true;
            }

            convertedValue = null;
            return false;
        }
    }
}