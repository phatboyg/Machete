namespace Machete.Internals.Mapping
{
    using System.ComponentModel;
    using System.Reflection;
    using Reflection;


    public class ObjectObjectMapper<T> :
        IObjectMapper<T>
    {
        readonly IObjectConverter _converter;
        readonly ReadWriteProperty<T> _property;
        readonly TypeConverter _typeConverter;

        public ObjectObjectMapper(ReadWriteProperty<T> property, IObjectConverter converter)
        {
            _property = property;
            _converter = converter;
            _typeConverter = TypeDescriptor.GetConverter(property.Property.PropertyType);
        }

        public void ApplyTo(T obj, IObjectValueProvider valueProvider)
        {
            if (valueProvider.TryGetValue(_property.Property.Name, out IObjectValueProvider propertyProvider))
            {
                var value = _converter.GetObject(propertyProvider);
                if (value != null)
                {
                    var valueType = value.GetType();
                    if (!valueType.GetTypeInfo().IsInstanceOfType(_property.Property.PropertyType))
                        if (_typeConverter.IsValid(value))
                            if (_typeConverter.CanConvertFrom(valueType))
                                value = _typeConverter.ConvertFrom(value);
                }

                _property.Set(obj, value);
            }
        }
    }
}