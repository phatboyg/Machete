namespace Machete.Internals.Mapping
{
    using System.Collections.Generic;
    using Reflection;


    public class ValueValueDictionaryObjectMapper<T, TKey, TValue> :
        IObjectMapper<T>
    {
        readonly ReadWriteProperty<T> _property;

        public ValueValueDictionaryObjectMapper(ReadWriteProperty<T> property)
        {
            _property = property;
        }

        public void ApplyTo(T obj, IObjectValueProvider valueProvider)
        {
            if (!valueProvider.TryGetValue(_property.Property.Name, out IArrayValueProvider values))
                return;

            var elements = new Dictionary<TKey, TValue>();

            for (var i = 0;; i++)
            {
                if (!values.TryGetValue(i, out IArrayValueProvider elementArray))
                    break;

                if (!elementArray.TryGetValue(0, out TKey elementKey))
                    continue;

                elementArray.TryGetValue(1, out TValue elementValue);

                elements[elementKey] = elementValue;
            }

            _property.Set(obj, elements);
        }
    }
}