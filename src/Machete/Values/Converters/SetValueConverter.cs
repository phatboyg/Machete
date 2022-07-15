namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;


    public class SetValueConverter<TValue> :
        IValueConverter<TValue>
    {
        readonly SetValueProvider<TValue> _valueProvider;

        public SetValueConverter(SetValueProvider<TValue> valueProvider)
        {
            _valueProvider = valueProvider;
        }

        public bool TryConvert(TextSlice slice, out Value<TValue> convertedValue)
        {
            Debug.Assert(slice != null);

            convertedValue = new ConvertedValue<TValue>(slice.SourceText, slice.SourceSpan, _valueProvider(slice.Text.ToString()));
            return true;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<TValue> convertedValue)
        {
            var value = _valueProvider(span);

            convertedValue = new SpanValue<TValue>(value);
            return true;
        }
    }
}