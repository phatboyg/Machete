namespace Machete.Slices.Providers
{
    using System.Reflection;
    using Internals.Reflection;
    using Texts;


    public class ValueSliceProvider<TEntity, TValue> :
        ITextSliceProvider<TEntity>
        where TEntity : Entity
    {
        readonly ReadOnlyProperty<TEntity, Value<TValue>> _property;
        readonly IValueFormatter<TValue> _formatter;

        public ValueSliceProvider(PropertyInfo propertyInfo, IValueFormatter<TValue> formatter)
        {
            _formatter = formatter;
            _property = new ReadOnlyProperty<TEntity, Value<TValue>>(propertyInfo);
        }

        public TextSlice GetSlice(TEntity entity)
        {
            var value = _property.GetProperty(entity);
            if (value.IsPresent && value.HasValue)
            {
                string text;
                if (_formatter.TryGetString(value, out text))
                    return new StringSlice(new StringText(text));
            }

            return Slice.Empty;
        }
    }
}