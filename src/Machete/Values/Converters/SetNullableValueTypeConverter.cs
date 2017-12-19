namespace Machete.Values.Converters
{
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

            var value = _valueProvider(slice);

            convertedValue = new ConvertedValue<TValue>(slice.SourceText, slice.SourceSpan, value ?? default, value.HasValue);
            return true;
        }
    }
}