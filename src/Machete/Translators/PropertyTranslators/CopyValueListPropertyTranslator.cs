namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Internals.Extensions;
    using Internals.Reflection;


    public class CopyValueListPropertyTranslator<TResult, TValue, TInput, TSchema> :
        IPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly WriteProperty<TResult, ValueList<TValue>> _property;
        readonly ReadOnlyProperty<TInput, ValueList<TValue>> _inputProperty;
        readonly string _propertyName;

        public CopyValueListPropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo, PropertyInfo inputPropertyInfo)
        {
            _propertyName = entityPropertyInfo.Name;
            _property = new WriteProperty<TResult, ValueList<TValue>>(implementationType, _propertyName);
            _inputProperty = new ReadOnlyProperty<TInput, ValueList<TValue>>(inputPropertyInfo);
        }

        public Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = _inputProperty.Get(context.Input) ?? ValueList.Missing<TValue>();

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