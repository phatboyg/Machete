namespace Machete.Internals.Mapping
{
    using System.Collections.Generic;


    public class ObjectArrayValueProvider :
        IArrayValueProvider
    {
        readonly object[] _values;

        public ObjectArrayValueProvider(object[] values)
        {
            _values = values;
        }

        public bool TryGetValue(int index, out object value)
        {
            if (index < 0 || index >= _values.Length)
            {
                value = null;
                return false;
            }

            value = _values[index];
            value = value switch
            {
                IDictionary<string, object> objects => new DictionaryObjectValueProvider(objects),
                object[] objects => new ObjectArrayValueProvider(objects),
                _ => _values[index]
            };

            return true;
        }

        public bool TryGetValue<T>(int index, out T value)
        {
            if (TryGetValue(index, out var obj))
            {
                if (obj is T objectValue)
                {
                    value = objectValue;
                    return true;
                }
            }

            value = default;
            return false;
        }
    }
}