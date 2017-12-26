namespace Machete.Internals.Reflection
{
    using System;
    using System.Linq.Expressions;
    using System.Reflection;


    public class ReadOnlyProperty<T>
    {
        public readonly Func<T, object> GetProperty;

        public ReadOnlyProperty(PropertyInfo property)
        {
            Property = property;
            GetProperty = GetGetMethod(Property);
        }

        public PropertyInfo Property { get; private set; }

        public object Get(T instance)
        {
            return GetProperty(instance);
        }

        static Func<T, object> GetGetMethod(PropertyInfo property)
        {
            var instance = Expression.Parameter(typeof(T), "instance");
            var call = Expression.Call(instance, property.GetMethod);
            var typeAs = Expression.TypeAs(call, typeof(object));
            return ExpressionCompiler.Compile<Func<T, object>>(Expression.Lambda<Func<T, object>>(typeAs, instance));
        }
    }
}