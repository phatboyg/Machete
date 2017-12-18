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
        readonly ReadOnlyProperty<TInput, Value<TPropertyEntity>> _inputProperty;
        readonly WriteProperty<TEntity, Value<TPropertyEntity>> _property;
        readonly string _propertyName;
        readonly SetValueProvider<TInput, TSchema, TPropertyEntity> _valueProvider;

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
            var inputValue = context.HasInput
                ? _inputProperty.Get(context.Input)
                : Value.Missing<TPropertyEntity>();

            var resultValue = _valueProvider(context.CreateValueContext(inputValue)) ?? Value.Missing<TPropertyEntity>();

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


    /// <summary>
    /// Sets an entity value
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPropertyEntity"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public class SetValuePropertyTranslator<TEntity, TPropertyEntity, TSchema> :
        IPropertyTranslator<TEntity, TSchema>
        where TSchema : Entity
        where TEntity : TSchema
    {
        readonly WriteProperty<TEntity, Value<TPropertyEntity>> _property;
        readonly string _propertyName;
        readonly SetValueProvider<TSchema, TPropertyEntity> _valueProvider;

        public SetValuePropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo, SetValueProvider<TSchema, TPropertyEntity> valueProvider)
        {
            _valueProvider = valueProvider;
            _propertyName = entityPropertyInfo.Name;
            _property = new WriteProperty<TEntity, Value<TPropertyEntity>>(implementationType, _propertyName);
        }

        public Task Apply(TEntity entity, TranslateContext<TSchema> context)
        {
            var resultValue = _valueProvider(context) ?? Value.Missing<TPropertyEntity>();

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