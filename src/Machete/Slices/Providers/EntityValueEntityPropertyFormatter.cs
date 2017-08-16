namespace Machete.Slices.Providers
{
    using System.Reflection;
    using Internals.Reflection;


    public class EntityValueEntityPropertyFormatter<TEntity, TSchema, TEntityValue> :
        IEntityPropertyFormatter<TEntity>
        where TEntity : TSchema
        where TSchema : Entity
        where TEntityValue : TSchema
    {
        readonly IEntityFormatter<TEntityValue> _entityFormatter;
        readonly ReadOnlyProperty<TEntity, Value<TEntityValue>> _property;

        public EntityValueEntityPropertyFormatter(PropertyInfo propertyInfo, IEntityFormatter<TEntityValue> entityFormatter)
        {
            _entityFormatter = entityFormatter;
            _property = new ReadOnlyProperty<TEntity, Value<TEntityValue>>(propertyInfo);
        }

        public void Format(FormatContext context, TEntity entity)
        {
            var value = _property.GetProperty(entity);
            if (value.HasValue)
            {
                _entityFormatter.Format(context, value.Value);
            }
        }
    }
}