namespace Machete.Entities.EntityProperties
{
    using System;
    using Internals.Reflection;
    using Values;


    /// <summary>
    ///     Maps an entity property from a single slice
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TValue">The value type</typeparam>
    public class InitializeEntityProperty<TEntity, TValue> :
        IEntityInitializer<TEntity>
        where TEntity : Entity
    {
        readonly TValue _value;
        readonly WriteProperty<TEntity, Value<TValue>> _writeProperty;

        public InitializeEntityProperty(Type implementationType, string propertyName, TValue value)
        {
            _value = value;

            _writeProperty = new WriteProperty<TEntity, Value<TValue>>(implementationType, propertyName);
        }

        public void Initialize(TEntity entity)
        {
            _writeProperty.Set(entity, new ConstantValue<TValue>(_value));
        }
    }
}