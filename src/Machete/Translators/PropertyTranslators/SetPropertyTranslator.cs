namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;


    public class SetPropertyTranslator<TEntity, TProperty, TSchema> :
        PropertyTranslator<TEntity, TProperty>,
        IPropertyTranslator<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly TProperty _propertyValue;

        public SetPropertyTranslator(Type implementationType, PropertyInfo propertyInfo, TProperty propertyValue)
            : base(propertyInfo)
        {
            _propertyValue = propertyValue;
        }

        public async Task Apply(TEntity entity, TranslateContext<TSchema> context)
        {
            Property.Set(entity, _propertyValue);
        }
    }
}