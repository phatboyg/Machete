namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;


    public class ReadWriteProperty<T> :
        ReadOnlyProperty<T>
    {
        public readonly Action<T, object> SetProperty;

        public ReadWriteProperty(PropertyInfo property)
            : base(property)
        {
            SetProperty = GetSetMethod(Property);
        }

        public void Set(T instance, object value)
        {
            SetProperty(instance, value);
        }

        static Action<T, object> GetSetMethod(PropertyInfo property)
        {
            if (!property.CanWrite)
                return (x, i) => { throw new InvalidOperationException("No setter available on " + property.Name); };

            var instance = Expression.Parameter(typeof(T), "instance");
            var value = Expression.Parameter(typeof(object), "value");
            var valueCast = property.PropertyType.GetTypeInfo().IsValueType
                ? Expression.Convert(value, property.PropertyType)
                : Expression.TypeAs(value, property.PropertyType);
            var call = Expression.Call(instance, property.SetMethod, valueCast);

            return ExpressionCompiler.Compile<Action<T, object>>(Expression.Lambda<Action<T, object>>(call, instance, value));
        }
    }
}