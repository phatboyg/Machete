namespace Machete.Formatters
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

        public void Format(FormatEntityContext<TEntity> context)
        {
            var value = _property.GetProperty(context.Entity);
            if (value.HasValue)
            {
                _entityFormatter.Format(context, value.Value);
            }
        }
    }
}