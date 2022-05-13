﻿namespace Machete.Internals.Mapping
{
    using System.ComponentModel;
    using Reflection;


    public class NullableValueObjectMapper<T, TValue> :
        IObjectMapper<T>
        where TValue : struct
    {
        readonly ReadWriteProperty<T> _property;

        public NullableValueObjectMapper(ReadWriteProperty<T> property)
        {
            _property = property;
        }

        public void ApplyTo(T obj, IObjectValueProvider valueProvider)
        {
            if (!valueProvider.TryGetValue(_property.Property.Name, out var value))
                return;

            var nullableValue = value as TValue?;
            if (!nullableValue.HasValue)
            {
                var converter = TypeDescriptor.GetConverter(typeof(TValue));
                nullableValue = converter.CanConvertFrom(value.GetType())
                    ? (TValue?) converter.ConvertFrom(value)
                    : null;
            }

            _property.Set(obj, nullableValue);
        }
    }
}