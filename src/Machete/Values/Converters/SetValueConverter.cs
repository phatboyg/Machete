namespace Machete.Values.Converters
{
    using System;


    public class SetValueConverter<TValue> :
        IValueConverter<TValue>
    {
        readonly Func<TextSlice, TValue> _valueProvider;

        public SetValueConverter(Func<TextSlice, TValue> valueProvider)
        {
            _valueProvider = valueProvider;
        }

        public bool TryConvert(TextSlice slice, out Value<TValue> convertedValue)
        {
            convertedValue = new ConvertedValue<TValue>(slice, _valueProvider(slice));
            return true;
        }
    }
}