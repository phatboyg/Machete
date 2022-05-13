namespace Machete.Internals.Mapping
{
    using System.Collections.Generic;
    using Reflection;


    public class ValueListObjectMapper<T, TElement> :
        IObjectMapper<T>
    {
        readonly ReadWriteProperty<T> _property;

        public ValueListObjectMapper(ReadWriteProperty<T> property)
        {
            _property = property;
        }

        public void ApplyTo(T obj, IObjectValueProvider valueProvider)
        {
            if (!valueProvider.TryGetValue(_property.Property.Name, out IArrayValueProvider values))
                return;

            var elements = new List<TElement>();

            for (int i = 0;; i++)
            {
                if (!values.TryGetValue(i, out TElement element))
                    break;

                elements.Add(element);
            }

            _property.Set(obj, elements.ToArray());
        }
    }
}