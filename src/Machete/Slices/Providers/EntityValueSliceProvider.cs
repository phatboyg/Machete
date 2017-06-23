namespace Machete.Slices.Providers
{
    using System.Reflection;
    using Internals.Reflection;


    public class EntityValueSliceProvider<TEntity, TSchema, TComponent> :
        ITextSliceProvider<TEntity>
        where TEntity : TSchema
        where TSchema : Entity
        where TComponent : TSchema
    {
        readonly IEntityFormatter<TComponent> _entityConverter;
        readonly ReadOnlyProperty<TEntity, Value<TComponent>> _property;

        public EntityValueSliceProvider(PropertyInfo propertyInfo, IEntityFormatter<TComponent> entityConverter)
        {
            _entityConverter = entityConverter;
            _property = new ReadOnlyProperty<TEntity, Value<TComponent>>(propertyInfo);
        }

        public TextSlice GetSlice(TEntity entity)
        {
            var value = _property.GetProperty(entity);
            if (value.HasValue)
            {
                return _entityConverter.FormatEntity(value.Value);
            }

            return Slice.Empty;
        }
    }
}