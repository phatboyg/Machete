namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Text;
    using Internals.Reflection;


    public abstract class PropertyTranslator<TResult, TProperty>
    {
        protected readonly WriteProperty<TResult, TProperty> Property;
        protected readonly string PropertyName;

        protected PropertyTranslator(Type implementationType, PropertyInfo propertyInfo)
        {
            PropertyName = propertyInfo.Name;

            Property = new WriteProperty<TResult, TProperty>(implementationType, propertyInfo.Name);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(PropertyName);
            sb.AppendLine(": (set)");

            return sb.ToString();
        }
    }
}