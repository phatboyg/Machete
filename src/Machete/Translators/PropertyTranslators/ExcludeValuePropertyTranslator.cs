namespace Machete.Translators.PropertyTranslators
{
    using System.Reflection;
    using System.Threading.Tasks;
    using Internals.Extensions;
    using Internals.Reflection;


    public class ExcludeValuePropertyTranslator<TResult, TValue, TInput, TSchema> :
        PropertyTranslator<TResult, Value<TValue>>,
        IInputPropertyTranslator<TResult, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TResult : TSchema
    {
        readonly IReadProperty<TResult, Value<TValue>> _readProperty;

        public ExcludeValuePropertyTranslator(PropertyInfo propertyInfo)
            : base(propertyInfo)
        {
            _readProperty = ReadPropertyCache<TResult>.GetProperty<Value<TValue>>(propertyInfo.Name);
        }

        public Task Apply(TResult entity, TranslateContext<TInput, TSchema> context)
        {
            var existing = _readProperty.Get(entity);
            if (existing == null)
                Property.Set(entity, Value.Missing<TValue>());

            return TaskUtil.Completed;
        }

        public override string ToString()
        {
            return $"{PropertyName}: (exclude)\n";
        }
    }
}