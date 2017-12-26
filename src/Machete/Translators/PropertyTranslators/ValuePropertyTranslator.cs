namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;
    using Internals.Extensions;


    /// <summary>
    /// Sets an entity value
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TSchema"></typeparam>
    public class ValuePropertyTranslator<TResult, TValue, TSchema> :
        PropertyTranslator<TResult, Value<TValue>>,
        IPropertyTranslator<TResult, TSchema>
        where TSchema : Entity
        where TResult : TSchema
    {
        readonly SetValueProvider<TSchema, TValue> _valueProvider;

        public ValuePropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo, SetValueProvider<TSchema, TValue> valueProvider)
            : base(entityPropertyInfo)
        {
            _valueProvider = valueProvider;
        }

        public Task Apply(TResult entity, TranslateContext<TSchema> context)
        {
            var resultValue = _valueProvider(context) ?? Value.Missing<TValue>();

            Property.Set(entity, resultValue);

            return TaskUtil.Completed;
        }
    }
}