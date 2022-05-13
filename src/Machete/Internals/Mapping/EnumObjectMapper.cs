namespace Machete.Internals.Mapping
{
    using System;
    using Reflection;


    public class EnumObjectMapper<T> :
        IObjectMapper<T>
    {
        readonly ReadWriteProperty<T> _property;

        public EnumObjectMapper(ReadWriteProperty<T> property)
        {
            _property = property;
        }

        public void ApplyTo(T obj, IObjectValueProvider valueProvider)
        {
            if (!valueProvider.TryGetValue(_property.Property.Name, out var value))
                return;

            switch (value)
            {
                case null: return;
                case T:
                    _property.Set(obj, value);
                    return;
                case string s:
                {
                    var enumValue = Enum.Parse(_property.Property.PropertyType, s);
                    _property.Set(obj, enumValue);
                    return;
                }
                default:
                {
                    var n = Enum.ToObject(_property.Property.PropertyType, value);
                    _property.Set(obj, n);
                    break;
                }
            }
        }
    }
}