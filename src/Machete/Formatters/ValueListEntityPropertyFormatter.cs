namespace Machete.Formatters
{
    using System.Reflection;
    using Internals.Reflection;


    public class ValueListEntityPropertyFormatter<TEntity, TValue> :
        IEntityPropertyFormatter<TEntity>
        where TEntity : Entity
    {
        readonly ReadOnlyProperty<TEntity, ValueList<TValue>> _property;
        readonly IValueFormatter<TValue> _formatter;

        public ValueListEntityPropertyFormatter(PropertyInfo propertyInfo, IValueFormatter<TValue> formatter)
        {
            _formatter = formatter;
            _property = new ReadOnlyProperty<TEntity, ValueList<TValue>>(propertyInfo);
        }

        public void Format(FormatEntityContext<TEntity> context)
        {
            var value = _property.GetProperty(context.Entity);
            if (value.HasValue)
            {
                for (int i = 0;; i++)
                {
                    if (!value.TryGetValue(i, out var currentValue) || !value.IsPresent)
                        break;

                    if (value.HasValue)
                        _formatter.Format(context.CreateValueContext(currentValue));
                }
            }
        }
    }
}