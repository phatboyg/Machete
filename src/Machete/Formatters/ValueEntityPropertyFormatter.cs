namespace Machete.Formatters
{
    using System.Reflection;
    using Internals.Reflection;
    using Slices;


    public class ValueEntityPropertyFormatter<TEntity, TValue> :
        IEntityPropertyFormatter<TEntity>
        where TEntity : Entity
    {
        readonly IValueFormatter<TValue> _formatter;
        readonly ReadOnlyProperty<TEntity, Value<TValue>> _property;

        public ValueEntityPropertyFormatter(PropertyInfo propertyInfo, IValueFormatter<TValue> formatter)
        {
            _formatter = formatter;
            _property = new ReadOnlyProperty<TEntity, Value<TValue>>(propertyInfo);
        }

        public void Format(FormatEntityContext<TEntity> context)
        {
            var value = _property.GetProperty(context.Entity);
            if (value.HasValue)
                if (value.Slice is ParsedTextSlice)
                    context.Append(value.Slice);
                else
                    _formatter.Format(context.CreateValueContext(value));
        }
    }
}