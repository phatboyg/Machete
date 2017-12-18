namespace Machete.Translators.PropertyTranslators
{
    using System;
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
        readonly ReadProperty<TResult, Value<TValue>> _readProperty;

        public ExcludeValuePropertyTranslator(Type implementationType, PropertyInfo propertyInfo)
            : base(implementationType, propertyInfo)
        {
            _readProperty = new ReadProperty<TResult, Value<TValue>>(implementationType, propertyInfo.Name);
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