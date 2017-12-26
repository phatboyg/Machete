namespace Machete.Formatters
{
    using System.Reflection;
    using Internals.Reflection;


    public class ValueEntityPropertyFormatter<TEntity, TValue> :
        IEntityPropertyFormatter<TEntity>
        where TEntity : Entity
    {
        readonly IValueFormatter<TValue> _formatter;
        readonly IReadProperty<TEntity, Value<TValue>> _property;

        public ValueEntityPropertyFormatter(PropertyInfo propertyInfo, IValueFormatter<TValue> formatter)
        {
            _formatter = formatter;
            _property = ReadPropertyCache<TEntity>.GetProperty<Value<TValue>>(propertyInfo.Name);
        }

        public void Format(FormatEntityContext<TEntity> context)
        {
            var value = _property.Get(context.Entity);
            if (value.HasValue)
                _formatter.Format(context.CreateValueContext(value));
        }
    }
}