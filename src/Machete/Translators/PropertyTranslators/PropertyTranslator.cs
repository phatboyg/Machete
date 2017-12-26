namespace Machete.Translators.PropertyTranslators
{
    using System.Reflection;
    using System.Text;
    using Internals.Reflection;


    public abstract class PropertyTranslator<TResult, TProperty>
    {
        protected readonly IWriteProperty<TResult, TProperty> Property;
        protected readonly string PropertyName;

        protected PropertyTranslator(PropertyInfo propertyInfo)
        {
            PropertyName = propertyInfo.Name;

            Property = WritePropertyCache<TResult>.GetProperty<TProperty>(propertyInfo.Name);
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