namespace Machete.Translators.PropertyTranslators
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
        readonly ReadOnlyProperty<TInput, Value<TPropertyEntity>> _inputProperty;
        readonly WriteProperty<TEntity, Value<TPropertyEntity>> _property;
        readonly string _propertyName;

        public SetValuePropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo, PropertyInfo inputPropertyInfo,
            SetValueProvider<TInput, TSchema, TPropertyEntity> valueProvider)
        {
            _valueProvider = valueProvider;
            _propertyName = entityPropertyInfo.Name;
            _property = new WriteProperty<TEntity, Value<TPropertyEntity>>(implementationType, _propertyName);
            _inputProperty = new ReadOnlyProperty<TInput, Value<TPropertyEntity>>(inputPropertyInfo);
        }

        public Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = context.HasInput ? _inputProperty.Get(context.Input) : Value.Missing<TPropertyEntity>();

            var subContext = context.CreateValueContext(inputValue);

            var resultValue = _valueProvider(subContext) ?? Value.Missing<TPropertyEntity>();

            _property.Set(entity, resultValue);

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