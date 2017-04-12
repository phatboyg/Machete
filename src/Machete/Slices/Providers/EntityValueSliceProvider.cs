namespace Machete.Slices.Providers
{
    using System.Reflection;
    using Internals.Reflection;


    public class EntityValueSliceProvider<TEntity, TComponent> :
        ITextSliceProvider<TEntity>
        where TEntity : Entity
        where TComponent : Entity
    {
        readonly IEntityMap<TComponent> _entityMap;
        readonly ReadOnlyProperty<TEntity, Value<TComponent>> _property;

        public EntityValueSliceProvider(PropertyInfo propertyInfo, IEntityMap<TComponent> entityMap)
        {
            _entityMap = entityMap;
            _property = new ReadOnlyProperty<TEntity, Value<TComponent>>(propertyInfo);
        }

        public TextSlice GetSlice(TEntity entity)
        {
            var value = _property.GetProperty(entity);
            if (value.HasValue)
            {
                return _entityMap.GetSlice(value.Value);
            }

            return Slice.Empty;
        }
    }
}