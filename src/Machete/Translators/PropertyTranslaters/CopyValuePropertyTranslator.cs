namespace Machete.Translators.PropertyTranslaters
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Internals.Extensions;
    using Internals.Reflection;


    public class CopyValuePropertyTranslator<TEntity, TPropertyEntity, TInput, TSchema> :
        IPropertyTranslator<TEntity, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TEntity : TSchema
    {
        readonly ReadOnlyProperty<TInput, Value<TPropertyEntity>> _inputProperty;
        readonly WriteProperty<TEntity, Value<TPropertyEntity>> _property;
        readonly string _propertyName;

        public CopyValuePropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo, PropertyInfo inputPropertyInfo)
        {
            _propertyName = entityPropertyInfo.Name;
            _property = new WriteProperty<TEntity, Value<TPropertyEntity>>(implementationType, _propertyName);
            _inputProperty = new ReadOnlyProperty<TInput, Value<TPropertyEntity>>(inputPropertyInfo);
        }

        public Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = _inputProperty.Get(context.Input) ?? Value.Missing<TPropertyEntity>();

            _property.Set(entity, inputValue);

            return TaskUtil.Completed;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(_propertyName);
            sb.Append(": (copy");

            if (_propertyName != _inputProperty.Property.Name)
                sb.AppendFormat(", source: {0}", _inputProperty.Property.Name);

            sb.AppendLine(")");

            return sb.ToString();
        }
    }
}