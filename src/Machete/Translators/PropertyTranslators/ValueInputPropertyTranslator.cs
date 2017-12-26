namespace Machete.Translators.PropertyTranslators
{
    using System.Reflection;
    using System.Threading.Tasks;
    using Internals.Extensions;


    public class ValueInputPropertyTranslator<TResult, TValue, TInput, TSchema> :
        InputPropertyTranslator<TResult, Value<TValue>, TInput>,
        IInputPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly SetValueProvider<TInput, TSchema, TValue> _valueProvider;

        public ValueInputPropertyTranslator(PropertyInfo propertyInfo, PropertyInfo inputPropertyInfo,
            SetValueProvider<TInput, TSchema, TValue> valueProvider)
            : base(propertyInfo, inputPropertyInfo)
        {
            _valueProvider = valueProvider;
        }

        public Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = context.HasInput
                ? InputProperty.Get(context.Input)
                : Value.Missing<TValue>();

            var resultValue = _valueProvider(context.CreateValueContext(inputValue)) ?? Value.Missing<TValue>();

            Property.Set(entity, resultValue);

            return TaskUtil.Completed;
        }
    }
}