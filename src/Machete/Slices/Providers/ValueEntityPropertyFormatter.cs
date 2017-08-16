namespace Machete.Slices.Providers
{
    using System.Reflection;
    using Internals.Reflection;


    public class ValueEntityPropertyFormatter<TEntity, TValue> :
        IEntityPropertyFormatter<TEntity>
        where TEntity : Entity
    {
        readonly ReadOnlyProperty<TEntity, Value<TValue>> _property;
        readonly IValueFormatter<TValue> _formatter;

        public ValueEntityPropertyFormatter(PropertyInfo propertyInfo, IValueFormatter<TValue> formatter)
        {
            _formatter = formatter;
            _property = new ReadOnlyProperty<TEntity, Value<TValue>>(propertyInfo);
        }

        public void Format(FormatContext context, TEntity entity)
        {
            var value = _property.GetProperty(entity);
            if (value.HasValue)
            {
                if (value.Slice is ParsedTextSlice)
                {
                    context.Append(value.Slice);
                }
                else
                {
                    _formatter.Format(context.CreateValueContext(value));
                }
            }
        }
    }
}