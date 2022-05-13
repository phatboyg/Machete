﻿namespace Machete.Internals.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Extensions;
    using Reflection;


    public class DynamicObjectConverter<T, TImplementation> :
        IObjectConverter
        where TImplementation : T, new()
        where T : class
    {
        readonly IObjectConverterCache _cache;
        readonly IObjectMapper<TImplementation>[] _converters;

        public DynamicObjectConverter(IObjectConverterCache cache)
        {
            _cache = cache;
            _converters = TypeCache<TImplementation>.ReadWritePropertyCache
                .Select(property => GetDictionaryToObjectConverter(property, property.Property.PropertyType))
                .ToArray();
        }

        public object GetObject(IObjectValueProvider valueProvider)
        {
            var implementation = new TImplementation();

            for (int i = 0; i < _converters.Length; i++)
                _converters[i].ApplyTo(implementation, valueProvider);

            return implementation;
        }

        IObjectMapper<TImplementation> GetDictionaryToObjectConverter(ReadWriteProperty<TImplementation> property, Type valueType)
        {
            var underlyingType = Nullable.GetUnderlyingType(valueType);
            if (underlyingType != null)
            {
                var converterType = typeof(NullableValueObjectMapper<,>).MakeGenericType(typeof(TImplementation), underlyingType);

                return (IObjectMapper<TImplementation>) Activator.CreateInstance(converterType, property);
            }

            if (valueType.GetTypeInfo().IsEnum)
                return new EnumObjectMapper<TImplementation>(property);

            if (valueType.IsArray)
            {
                var elementType = valueType.GetElementType();
                if (ValueObject.IsValueObjectType(elementType))
                {
                    var valueConverterType = typeof(ValueArrayObjectMapper<,>).MakeGenericType(typeof(TImplementation), elementType);
                    return (IObjectMapper<TImplementation>) Activator.CreateInstance(valueConverterType, property);
                }

                var elementConverter = _cache.GetConverter(elementType);

                var converterType = typeof(ObjectArrayObjectMapper<,>).MakeGenericType(typeof(TImplementation), elementType);
                return (IObjectMapper<TImplementation>) Activator.CreateInstance(converterType, property, elementConverter);
            }

            if (ValueObject.IsValueObjectType(valueType))
                return new ValueObjectMapper<TImplementation>(property);

            if (valueType.ClosesType(typeof(IEnumerable<>)))
            {
                if (valueType.ClosesType(typeof(IDictionary<,>)))
                {
                    var genericArguments = valueType.GetClosingArguments(typeof(IDictionary<,>)).ToArray();

                    var keyType = genericArguments[0];
                    var elementType = genericArguments[1];


                    if (ValueObject.IsValueObjectType(keyType))
                        if (ValueObject.IsValueObjectType(elementType))
                        {
                            var valueConverterType = typeof(ValueValueDictionaryObjectMapper<,,>).MakeGenericType(typeof(TImplementation), keyType, elementType);
                            return (IObjectMapper<TImplementation>) Activator.CreateInstance(valueConverterType, property);
                        }
                        else
                        {
                            var elementConverter = _cache.GetConverter(elementType);
                            var valueConverterType = typeof(ValueObjectDictionaryObjectMapper<,,>).MakeGenericType(typeof(TImplementation), keyType, elementType);
                            return (IObjectMapper<TImplementation>) Activator.CreateInstance(valueConverterType, property, elementConverter);
                        }

                    throw new InvalidOperationException("A dictionary with a reference type key is not supported: " + property.Property.Name);
                }


                if (valueType.ClosesType(typeof(IList<>)) || valueType.ClosesType(typeof(IEnumerable<>)))
                {
                    var genericArguments = valueType.GetClosingArguments(typeof(IEnumerable<>)).ToArray();
                    var elementType = genericArguments[0];

                    if (ValueObject.IsValueObjectType(elementType))
                    {
                        var valueConverterType = typeof(ValueListObjectMapper<,>).MakeGenericType(typeof(TImplementation), elementType);

                        return (IObjectMapper<TImplementation>) Activator.CreateInstance(valueConverterType, property);
                    }

                    var elementConverter = _cache.GetConverter(elementType);

                    var converterType = typeof(ObjectListObjectMapper<,>).MakeGenericType(typeof(TImplementation), elementType);

                    return (IObjectMapper<TImplementation>) Activator.CreateInstance(converterType, property, elementConverter);
                }
            }

            return new ObjectObjectMapper<TImplementation>(property, _cache.GetConverter(valueType));
        }
    }
}