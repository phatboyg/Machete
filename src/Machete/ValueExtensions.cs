namespace Machete
{
    using System;
    using System.Collections.Generic;
    using Entities;
    using Entities.EntityProperties;
    using Internals.Extensions;
    using Parsers;
    using Translators.PropertyTranslators;
    using Values;


    public static class ValueExtensions
    {
        /// <summary>
        /// Returns true if <see cref="IValue.HasValue"/> is true and the <see cref="Value{TValue}.Value"/> equals <paramref name="expected"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expected"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsEqualTo<T>(this Value<T> value, T expected)
        {
            return value.HasValue && value.Value.Equals(expected);
        }

        /// <summary>
        /// Returns the value of <paramref name="value"/>, or the <paramref name="defaultValue"/> if HasValue is false.
        /// </summary>
        /// <param name="value">The value to return</param>
        /// <param name="defaultValue">The default value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static T ValueOrDefault<T>(this Value<T> value, T defaultValue = default)
        {
            return value != null && value.HasValue ? value.Value : defaultValue;
        }

        /// <summary>
        /// Returns the value of <paramref name="value"/> or an empty string if the value does not have a value.
        /// </summary>
        /// <param name="value">The value</param>
        public static string ValueOrEmpty(this Value<string> value)
        {
            return value != null && value.HasValue ? value.Value ?? string.Empty : string.Empty;
        }

        /// <summary>
        /// Returns the <see cref="Value{T}"/>, if HasValue is true, otherwise returns the other value.
        /// </summary>
        /// <param name="value">The first value</param>
        /// <param name="other">The alternate value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static Value<T> Or<T>(this Value<T> value, Value<T> other)
        {
            return value != null && value.HasValue ? value : other ?? Value.Missing<T>();
        }

        /// <summary>
        /// Safely returns the <see cref="Value{TValue}"/> from a complex object.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="projection"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static Value<TValue> Select<T, TValue>(this Value<T> source, Func<T, Value<TValue>> projection)
        {
            if (source == null || !source.HasValue)
                return Value.Missing<TValue>();

            return projection(source.Value) ?? Value.Missing<TValue>();
        }

//        public static ValueList<TEntity> As<T, TEntity>(this ValueList<T> source)
//            where T : Entity
//            where TEntity : Entity
//        {
//            if (source == null || !source.HasValue)
//                return ValueList.Missing<TEntity>();
//
//            var convertedValues = new List<Value<TEntity>>();
//            IValueConverter<TEntity> converter = GetConverter<TEntity>();
//            for (int index = 0; source.TryGetValue(index, out Value<T> input); index++)
//            {
//                if (!TryConvert(input, converter, out Value<TEntity> converted))
//                    break;
//                
//                convertedValues.Add(converted);
//            }
//
//            return new ListValueList<TEntity>(convertedValues);
//        }

        public static Value<TEntity> As<T, TEntity>(this Value<T> source)
            where T : Entity
            where TEntity : Entity
        {
            if (source == null || !source.HasValue)
                return Value.Missing<TEntity>();

            var convertedValues = new List<Value<TEntity>>();
//            IEntityConverter converter = GetConverter<TEntity>();
            
            var properties = typeof(TEntity).GetAllProperties();
            var initializers = new List<IEntityInitializer<TEntity>>();

            foreach (var property in properties)
            {
                if (!source.HasValue)
                    break;
                
                initializers.Add(new PropertyInitializer<TEntity>(property.Name, source.Value));
            }
//            IEntityConverter converter = new DynamicEntityConverter<TEntity>(source.Value.EntityInfo, properties)
//            for (int index = 0; source.TryGetValue(index, out Value<T> input); index++)
//            {
//                if (!TryConvert(input, converter, out Value<TEntity> converted))
//                    break;
//                
//                convertedValues.Add(converted);
//            }
//
//            return new ListValueList<TEntity>(convertedValues);
            throw new NotImplementedException();
        }

        static bool TryConvert<T, TEntity>(Value<T> input, out Value<TEntity> value)
            where T : Entity
            where TEntity : Entity
        {
            if (!input.HasValue)
            {
                value = Value.Missing<TEntity>();
                return false;
            }
            
            // var convertedValue = new ConvertValue(input.Value.ParsedText, )
            // input.Value.ParsedText
            throw new NotImplementedException();
        }
    }


    public class PropertyInitializer<TEntity> :
        IEntityInitializer<TEntity>
    where TEntity : Entity
    {
        public PropertyInitializer(string propertyName, object sourceValue)
        {
            throw new NotImplementedException();
        }

        public void Initialize(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}