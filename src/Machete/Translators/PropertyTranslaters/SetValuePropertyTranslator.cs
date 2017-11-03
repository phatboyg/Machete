namespace Machete.Translators.PropertyTranslaters
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Internals.Extensions;
    using Internals.Reflection;


    public class SetValuePropertyTranslator<TEntity, TPropertyEntity, TInput, TSchema> :
        IPropertyTranslator<TEntity, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TEntity : TSchema
    {
        readonly SetValueProvider<TInput, TSchema, TPropertyEntity> _valueProvider;
        readonly WriteProperty<TEntity, Value<TPropertyEntity>> _property;
        readonly string _propertyName;

        public SetValuePropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo, SetValueProvider<TInput, TSchema, TPropertyEntity> valueProvider)
        {
            _valueProvider = valueProvider;
            _propertyName = entityPropertyInfo.Name;
            _property = new WriteProperty<TEntity, Value<TPropertyEntity>>(implementationType, _propertyName);
        }

        public Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = _valueProvider(context) ?? Value.Missing<TPropertyEntity>();

            _property.Set(entity, inputValue);

            return TaskUtil.Completed;
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