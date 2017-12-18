namespace Machete.Translators.PropertyTranslators
{
    using System;
    using System.Reflection;
    using System.Threading.Tasks;
    using Internals.Extensions;
    using Internals.Reflection;


    public class ExcludeValueListPropertyTranslator<TEntity, TPropertyEntity, TInput, TSchema> :
        PropertyTranslator<TEntity, ValueList<TPropertyEntity>>,
        IInputPropertyTranslator<TEntity, TInput, TSchema>
        where TSchema : Entity
        where TInput : TSchema
        where TEntity : TSchema
    {
        readonly ReadProperty<TEntity, ValueList<TPropertyEntity>> _readProperty;

        public ExcludeValueListPropertyTranslator(Type implementationType, PropertyInfo propertyInfo)
            : base(implementationType, propertyInfo)
        {
            _readProperty = new ReadProperty<TEntity, ValueList<TPropertyEntity>>(implementationType, propertyInfo.Name);
        }

        public Task Apply(TEntity entity, TranslateContext<TInput, TSchema> context)
        {
            var existing = _readProperty.Get(entity);
            if (existing == null)
                Property.Set(entity, ValueList.Missing<TPropertyEntity>());

            return TaskUtil.Completed;
        }

        public override string ToString()
        {
            return $"{PropertyName}: (exclude)\n";
        }
    }
}