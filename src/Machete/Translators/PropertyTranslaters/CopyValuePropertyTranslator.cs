namespace Machete.Translators
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;
    using Internals;
    using Internals.Extensions;
    using Internals.Reflection;


    public class CopyValuePropertyTranslator<TEntity, TPropertyEntity, TInput, TSchema> :
        IPropertyTranslator<TEntity, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TEntity : TSchema
    {
        readonly WriteProperty<TEntity, Value<TPropertyEntity>> _property;
        readonly ReadOnlyProperty<TInput, Value<TPropertyEntity>> _inputProperty;

        public CopyValuePropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo, PropertyInfo inputPropertyInfo)
        {
            _property = new WriteProperty<TEntity, Value<TPropertyEntity>>(implementationType, entityPropertyInfo.Name);
            _inputProperty = new ReadOnlyProperty<TInput, Value<TPropertyEntity>>(inputPropertyInfo);
        }

        public Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            var inputValue = _inputProperty.Get(context.Input) ?? Value.Missing<TPropertyEntity>();

            _property.Set(entity, inputValue);

            return TaskUtil.Completed;
        }
    }
}