namespace Machete.Internals.Reflection
{
    using System;
    using System.Collections.Generic;
    using Extensions;


    public class ReadPropertyCache<TEntity> :
        IReadPropertyCache<TEntity>
    {
        readonly Type _implementationType;
        readonly IDictionary<string, IReadProperty<TEntity>> _properties;

        ReadPropertyCache()
        {
            _implementationType = TypeCache<TEntity>.ImplementationType;

            _properties = new Dictionary<string, IReadProperty<TEntity>>(StringComparer.OrdinalIgnoreCase);
        }

        IReadProperty<TEntity, TProperty> IReadPropertyCache<TEntity>.GetProperty<TProperty>(string name)
        {
            lock (_properties)
            {
                if (_properties.TryGetValue(name, out var property))
                    return property as IReadProperty<TEntity, TProperty>;

                var writeProperty = new ReadProperty<TEntity, TProperty>(_implementationType, name);

                _properties[name] = writeProperty;

                return writeProperty;
            }
        }

        public static IReadProperty<TEntity, TProperty> GetProperty<TProperty>(string name)
        {
            return Cached.PropertyCache.GetProperty<TProperty>(name);
        }


        static class Cached
        {
            internal static readonly IReadPropertyCache<TEntity> PropertyCache = new ReadPropertyCache<TEntity>();
        }
    }
}