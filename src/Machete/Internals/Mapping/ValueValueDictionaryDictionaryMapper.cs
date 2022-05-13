namespace Machete.Internals.Mapping
{
    using System.Collections.Generic;
    using System.Linq;
    using Reflection;


    public class ValueValueDictionaryDictionaryMapper<T, TKey, TValue> :
        IDictionaryMapper<T>
    {
        readonly ReadOnlyProperty<T> _property;

        public ValueValueDictionaryDictionaryMapper(ReadOnlyProperty<T> property)
        {
            _property = property;
        }

        public void WritePropertyToDictionary(IDictionary<string, object> dictionary, T obj)
        {
            var value = _property.Get(obj);

            if (value is not IDictionary<TKey, TValue> values)
                return;

            var elementArray = values.Select(element => new object[] {element.Key, element.Value})
                .ToArray<object>();

            dictionary.Add(_property.Property.Name, elementArray);
        }
    }
}