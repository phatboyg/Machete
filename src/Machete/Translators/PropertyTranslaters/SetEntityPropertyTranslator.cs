namespace Machete.Translators.PropertyTranslaters
{
    using System.Reflection;
    using System.Threading.Tasks;
    using Internals.Reflection;


    public class SetEntityPropertyTranslator<TEntity, TProperty, TInput, TSchema> :
        IEntityPropertyTranslator<TEntity, TInput, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
        where TInput : TSchema
    {
        readonly ITranslatePropertyProvider<TProperty, TInput, TSchema> _propertyProvider;
        readonly ReadWriteProperty<TEntity, TProperty> _property;

        public SetEntityPropertyTranslator(PropertyInfo propertyInfo, ITranslatePropertyProvider<TProperty, TInput, TSchema> propertyProvider)
        {
            _propertyProvider = propertyProvider;
            _property = new ReadWriteProperty<TEntity, TProperty>(propertyInfo);
        }

        public async Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            var value = await _propertyProvider.GetProperty(context).ConfigureAwait(false);

            _property.Set(entity, value);
        }
    }
}