namespace Machete.Values.Converters
{
    using System;
    using System.Diagnostics;


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
            Debug.Assert(slice != null);

            convertedValue = new ConvertedValue<TValue>(slice.SourceText, slice.SourceSpan, _valueProvider(slice));
            return true;
        }
    }
}