namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Internals.Extensions;


    public class CopyValuePropertyTranslator<TResult, TValue, TInput, TSchema> :
        InputPropertyTranslator<TResult, Value<TValue>, TInput>,
        IInputPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        public CopyValuePropertyTranslator(Type implementationType, PropertyInfo propertyInfo, PropertyInfo inputPropertyInfo)
            : base(implementationType, propertyInfo, inputPropertyInfo)
        {
        }

        public Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = context.HasInput ? InputProperty.Get(context.Input) : Value.Missing<TValue>();

            Property.Set(entity, inputValue ?? Value.Missing<TValue>());

            return TaskUtil.Completed;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(PropertyName);
            sb.Append(": (copy");

            if (PropertyName != InputPropertyName)
                sb.AppendFormat(", source: {0}", InputPropertyName);

            sb.AppendLine(")");

            return sb.ToString();
        }
    }
}