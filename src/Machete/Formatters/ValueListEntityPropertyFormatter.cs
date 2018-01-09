namespace Machete.Formatters
{
    using System;
    using System.Reflection;
    using Internals.Reflection;


    public class ValueListEntityPropertyFormatter<TEntity, TValue> :
        IEntityPropertyFormatter<TEntity>
        where TEntity : Entity
    {
        readonly IReadProperty<TEntity, ValueList<TValue>> _property;
        readonly IValueFormatter<TValue> _formatter;

        public ValueListEntityPropertyFormatter(PropertyInfo propertyInfo, IValueFormatter<TValue> formatter)
        {
            _formatter = formatter ?? throw new ArgumentNullException(nameof(formatter));
            _property = ReadPropertyCache<TEntity>.GetProperty<ValueList<TValue>>(propertyInfo.Name);
        }

        public void Format(FormatEntityContext<TEntity> context)
        {
            var value = _property.Get(context.Entity);
            if (!value.HasValue)
                return;
            
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