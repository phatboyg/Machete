namespace Machete.Translators.PropertyTranslaters
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;
    using Internals.Extensions;
    using Internals.Reflection;


    public class ExcludeValuePropertyTranslator<TEntity, TPropertyEntity, TInput, TSchema> :
        IPropertyTranslator<TEntity, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TEntity : TSchema
    {
        readonly WriteProperty<TEntity, Value<TPropertyEntity>> _property;
        readonly ReadProperty<TEntity, Value<TPropertyEntity>> _readProperty;

        public ExcludeValuePropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo)
        {
            _property = new WriteProperty<TEntity, Value<TPropertyEntity>>(implementationType, entityPropertyInfo.Name);
            _readProperty = new ReadProperty<TEntity, Value<TPropertyEntity>>(implementationType, entityPropertyInfo.Name);
        }

        public Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            var existing = _readProperty.Get(entity);
            if (existing == null)
                _property.Set(entity, Value.Missing<TPropertyEntity>());

            return TaskUtil.Completed;
        }
    }
}