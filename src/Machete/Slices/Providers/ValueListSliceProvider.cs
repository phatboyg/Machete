namespace Machete.Slices.Providers
{
    using System.Reflection;
    using Internals.Reflection;
    using Texts;


    public class ValueListSliceProvider<TEntity, TValue> :
        ITextSliceProvider<TEntity>
        where TEntity : Entity
    {
        readonly ReadOnlyProperty<TEntity, ValueList<TValue>> _property;
        readonly IValueFormatter<TValue> _formatter;

        public ValueListSliceProvider(PropertyInfo propertyInfo, IValueFormatter<TValue> formatter)
        {
            _formatter = formatter;
            _property = new ReadOnlyProperty<TEntity, ValueList<TValue>>(propertyInfo);
        }

        public TextSlice GetSlice(TEntity entity)
        {
            var value = _property.GetProperty(entity);
            if (value.IsPresent && value.HasValue)
            {
                Value<TValue> firstValue;
                if (value.TryGetValue(0, out firstValue) && firstValue.HasValue)
                {
                    string text;
                    if (_formatter.TryGetString(firstValue, out text))
                        return new StringSlice(new StringText(text));
                }
            }

            return Slice.Empty;
        }
    }
}