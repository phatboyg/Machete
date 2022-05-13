﻿namespace Machete.Internals.Mapping
{
    using System.Collections.Generic;
    using Reflection;


    public class ObjectArrayObjectMapper<T, TElement> :
        IObjectMapper<T>
    {
        readonly IObjectConverter _converter;
        readonly ReadWriteProperty<T> _property;

        public ObjectArrayObjectMapper(ReadWriteProperty<T> property,
            IObjectConverter converter)
        {
            _property = property;
            _converter = converter;
        }

        public void ApplyTo(T obj, IObjectValueProvider valueProvider)
        {
            if (!valueProvider.TryGetValue(_property.Property.Name, out IArrayValueProvider values))
                return;

            var elements = new List<TElement>();

            for (int i = 0;; i++)
            {
                if (!values.TryGetValue(i, out IObjectValueProvider elementValueProvider))
                    break;

                var element = (TElement) _converter.GetObject(elementValueProvider);
                elements.Add(element);
            }

            _property.Set(obj, elements.ToArray());
        }
    }
}