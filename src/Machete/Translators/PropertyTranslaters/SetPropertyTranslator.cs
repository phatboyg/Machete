namespace Machete.Translators.PropertyTranslaters
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;
    using Internals.Reflection;


    public class SetPropertyTranslator<TEntity, TProperty, TInput, TSchema> :
        IPropertyTranslator<TEntity, TInput, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
        where TInput : TSchema
    {
        readonly ITranslatePropertyProvider<TProperty, TInput, TSchema> _propertyProvider;
        readonly WriteProperty<TEntity, TProperty> _property;

        public SetPropertyTranslator(Type implementationType, PropertyInfo propertyInfo, ITranslatePropertyProvider<TProperty, TInput, TSchema> propertyProvider)
        {
            _propertyProvider = propertyProvider;
            _property = new WriteProperty<TEntity, TProperty>(implementationType, propertyInfo.Name);
        }

        public async Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            var value = await _propertyProvider.GetProperty(context).ConfigureAwait(false);

            _property.Set(entity, value);
        }
    }
}