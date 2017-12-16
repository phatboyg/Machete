namespace Machete.Translators.PropertyTranslators
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
        readonly string _propertyName;

        public ExcludeValuePropertyTranslator(Type implementationType, PropertyInfo entityPropertyInfo)
        {
            _propertyName = entityPropertyInfo.Name;
            _property = new WriteProperty<TEntity, Value<TPropertyEntity>>(implementationType, _propertyName);
            _readProperty = new ReadProperty<TEntity, Value<TPropertyEntity>>(implementationType, _propertyName);
        }

        public Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            var existing = _readProperty.Get(entity);
            if (existing == null)
                _property.Set(entity, Value.Missing<TPropertyEntity>());

            return TaskUtil.Completed;
        }

        public override string ToString()
        {
            return $"{_propertyName}: (exclude)\n";
        }
    }
}