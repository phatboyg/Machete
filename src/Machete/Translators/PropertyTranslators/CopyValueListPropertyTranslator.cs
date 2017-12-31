namespace Machete.Translators.PropertyTranslators
{
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using Internals.Extensions;


    public class CopyValueListPropertyTranslator<TResult, TValue, TInput, TSchema> :
        InputPropertyTranslator<TResult, ValueList<TValue>, TInput>,
        IInputPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        public CopyValueListPropertyTranslator(PropertyInfo entityPropertyInfo, PropertyInfo inputPropertyInfo)
            : base(entityPropertyInfo, inputPropertyInfo)
        {
        }

        public Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = context.HasInput ? InputProperty.Get(context.Input) : ValueList.Missing<TValue>();

            Property.Set(entity, inputValue ?? ValueList.Missing<TValue>());

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