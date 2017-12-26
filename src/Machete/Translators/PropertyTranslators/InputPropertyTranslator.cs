namespace Machete.Translators.PropertyTranslators
{
    using System.Reflection;
    using System.Text;
    using Internals.Reflection;


    public abstract class InputPropertyTranslator<TResult, TProperty, TInput> :
        PropertyTranslator<TResult, TProperty>
    {
        protected readonly IReadProperty<TInput, TProperty> InputProperty;
        protected readonly string InputPropertyName;

        protected InputPropertyTranslator(PropertyInfo propertyInfo, PropertyInfo inputPropertyInfo)
            : base(propertyInfo)
        {
            InputProperty = ReadPropertyCache<TInput>.GetProperty<TProperty>(inputPropertyInfo.Name);
            InputPropertyName = inputPropertyInfo.Name;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(PropertyName);
            sb.Append(": (set");

            if (PropertyName != InputPropertyName)
                sb.AppendFormat(", source: {0}", InputPropertyName);

            sb.AppendLine(")");

            return sb.ToString();
        }
    }
}