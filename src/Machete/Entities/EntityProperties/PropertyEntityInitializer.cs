namespace Machete.Entities.EntityProperties
{
    using Internals.Reflection;
    using Values;


    /// <summary>
    ///     Maps an entity property from a single slice
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TValue">The value type</typeparam>
    public class PropertyEntityInitializer<TEntity, TValue> :
        IEntityInitializer<TEntity>
        where TEntity : Entity
    {
        readonly TValue _value;
        readonly IWriteProperty<TEntity, Value<TValue>> _writeProperty;

        public PropertyEntityInitializer(string propertyName, TValue value)
        {
            _value = value;

            _writeProperty = WritePropertyCache<TEntity>.GetProperty<Value<TValue>>(propertyName);
        }

        public void Initialize(TEntity entity)
        {
            _writeProperty.Set(entity, new ConstantValue<TValue>(_value));
        }
    }
}