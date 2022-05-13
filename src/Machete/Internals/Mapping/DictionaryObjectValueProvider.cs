namespace Machete.Internals.Mapping
{
    using System.Collections.Generic;


    public class DictionaryObjectValueProvider :
        IObjectValueProvider
    {
        readonly IDictionary<string, object> _dictionary;

        public DictionaryObjectValueProvider(IDictionary<string, object> dictionary)
        {
            _dictionary = dictionary;
        }

        public bool TryGetValue(string name, out object value)
        {
            var found = _dictionary.TryGetValue(name, out value);

            if (found)
            {
                value = value switch
                {
                    object[] objects => new ObjectArrayValueProvider(objects),
                    _ => value switch
                    {
                        IDictionary<string, object> objects => new DictionaryObjectValueProvider(objects),
                        _ => value
                    }
                };
            }

            return found;
        }

        public bool TryGetValue<T>(string name, out T value)
        {
            object obj;
            if (TryGetValue(name, out obj))
                if (obj is T)
                {
                    value = (T) obj;
                    return true;
                }

            value = default(T);
            return false;
        }
    }
}