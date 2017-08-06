namespace Machete.Translators.PropertyTranslaters.PropertyProviders
{
    using System.Reflection;
    using System.Threading.Tasks;
    using Internals.Reflection;


    public class InputValueTranslatePropertyProvider<TValue, TInput, TSchema> :
        ITranslatePropertyProvider<Value<TValue>, TInput, TSchema>
        where TInput : TSchema
        where TSchema : Entity
    {
        readonly ReadOnlyProperty<TInput, Value<TValue>> _property;

        public InputValueTranslatePropertyProvider(PropertyInfo propertyInfo)
        {
            _property = new ReadOnlyProperty<TInput, Value<TValue>>(propertyInfo);
        }

        public Task<Value<TValue>> GetProperty(TranslateContext<TInput, TSchema> context)
        {
            if (context.HasInput)
                return Task.FromResult(_property.Get(context.Input));

            return Task.FromResult(Value.Missing<TValue>());
        }
    }
}