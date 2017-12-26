namespace Machete.Internals.Reflection
{
    using System;
    using System.Collections.Generic;
    using Extensions;


    public class WritePropertyCache<TEntity> :
        IWritePropertyCache<TEntity>
    {
        readonly Type _implementationType;
        readonly IDictionary<string, IWriteProperty<TEntity>> _properties;

        WritePropertyCache()
        {
            _implementationType = TypeCache<TEntity>.ImplementationType;

            _properties = new Dictionary<string, IWriteProperty<TEntity>>(StringComparer.OrdinalIgnoreCase);
        }

        IWriteProperty<TEntity, TProperty> IWritePropertyCache<TEntity>.GetProperty<TProperty>(string name)
        {
            lock (_properties)
            {
                if (_properties.TryGetValue(name, out var property))
                    return property as IWriteProperty<TEntity, TProperty>;

                var writeProperty = new WriteProperty<TEntity, TProperty>(_implementationType, name);

                _properties[name] = writeProperty;

                return writeProperty;
            }
        }

        public static IWriteProperty<TEntity, TProperty> GetProperty<TProperty>(string name)
        {
            return Cached.PropertyCache.GetProperty<TProperty>(name);
        }


        static class Cached
        {
            internal static readonly IWritePropertyCache<TEntity> PropertyCache = new WritePropertyCache<TEntity>();
        }
    }
}