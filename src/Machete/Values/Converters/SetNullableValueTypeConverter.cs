namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;


    public class SetNullableValueTypeConverter<TValue> :
        IValueConverter<TValue>
        where TValue : struct
    {
        readonly SetNullableValueTypeProvider<TValue> _valueProvider;

        public SetNullableValueTypeConverter(SetNullableValueTypeProvider<TValue> valueProvider)
        {
            _valueProvider = valueProvider;
        }

        public bool TryConvert(TextSlice slice, out Value<TValue> convertedValue)
        {
            Debug.Assert(slice != null);

            var value = _valueProvider(slice.Text.ToString());

            convertedValue = new ConvertedValue<TValue>(slice.SourceText, slice.SourceSpan, value ?? default, value.HasValue);
            return true;
        }

        public bool TryConvert(ReadOnlySpan<char> span, out Value<TValue> convertedValue)
        {
            var value = _valueProvider(span);

            convertedValue = new SpanValue<TValue>(value ?? default, value.HasValue);
            return true;
        }
    }
}