namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Internals.Reflection;


    public class SetPropertyTranslator<TEntity, TProperty, TInput, TSchema> :
        SetPropertyTranslator<TEntity, TProperty, TSchema>,
        IPropertyTranslator<TEntity, TInput, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
        where TInput : TSchema
    {
        public SetPropertyTranslator(Type implementationType, PropertyInfo propertyInfo, TProperty propertyValue)
            : base(implementationType, propertyInfo, propertyValue)
        {
        }

        public async Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            Property.Set(entity, PropertyValue);
        }
    }


    public class SetPropertyTranslator<TEntity, TProperty, TSchema> :
        IPropertyTranslator<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        protected readonly TProperty PropertyValue;
        protected readonly WriteProperty<TEntity, TProperty> Property;
        readonly string _propertyName;

        public SetPropertyTranslator(Type implementationType, PropertyInfo propertyInfo, TProperty propertyValue)
        {
            PropertyValue = propertyValue;
            _propertyName = propertyInfo.Name;

            Property = new WriteProperty<TEntity, TProperty>(implementationType, propertyInfo.Name);
        }

        public async Task Apply(TEntity entity, TranslateContext<TSchema> context)
        {
            Property.Set(entity, PropertyValue);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(_propertyName);
            sb.AppendLine(": (set)");

            return sb.ToString();
        }
    }
}