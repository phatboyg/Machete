namespace Machete.Internals.Mapping
{
    using System.Collections.Generic;
    using Reflection;


    public class ValueObjectDictionaryObjectMapper<T, TKey, TValue> :
        IObjectMapper<T>
    {
        readonly ReadWriteProperty<T> _property;
        readonly IObjectConverter _valueConverter;

        public ValueObjectDictionaryObjectMapper(ReadWriteProperty<T> property, IObjectConverter valueConverter)
        {
            _property = property;
            _valueConverter = valueConverter;
        }

        public void ApplyTo(T obj, IObjectValueProvider valueProvider)
        {
            if (!valueProvider.TryGetValue(_property.Property.Name, out IArrayValueProvider values))
                return;

            var elements = new Dictionary<TKey, TValue>();

            for (int i = 0;; i++)
            {
                if (!values.TryGetValue(i, out IArrayValueProvider elementArray))
                    break;

                if (elementArray.TryGetValue(0, out TKey elementKey))
                {
                    var elementValue = default(TValue);
                    if (elementArray.TryGetValue(1, out IObjectValueProvider elementValueProvider))
                        elementValue = (TValue) _valueConverter.GetObject(elementValueProvider);

                    elements[elementKey] = elementValue;
                }
            }

            _property.Set(obj, elements);
        }
    }
}