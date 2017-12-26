namespace Machete.Internals.Extensions
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using Mapping;
    using Reflection;


    public static class TypeCache
    {
        internal static readonly IDictionaryConverterCache DictionaryConverterCache = new DictionaryConverterCache();
        internal static readonly IObjectConverterCache ObjectConverterCache = new DynamicObjectConverterCache();

        static CachedType GetOrAdd(Type type)
        {
            return Cached.Instance.GetOrAdd(type, _ =>
                (CachedType) Activator.CreateInstance(typeof(CachedType<>).MakeGenericType(type)));
        }

        public static string GetShortName(Type type)
        {
            return GetOrAdd(type).ShortName;
        }

        public static Type GetImplementationType(Type type)
        {
            return GetOrAdd(type).ImplementationType;
        }


        static class Cached
        {
            internal static readonly ConcurrentDictionary<Type, CachedType> Instance = new ConcurrentDictionary<Type, CachedType>();
        }


        interface CachedType
        {
            string ShortName { get; }
            Type ImplementationType { get; }
        }


        class CachedType<T> :
            CachedType
        {
            public string ShortName => TypeCache<T>.ShortName;
            public Type ImplementationType => TypeCache<T>.ImplementationType;
        }
    }


    public class TypeCache<T> :
        ITypeCache<T>
    {
        readonly Lazy<IObjectConverter> _converter;
        readonly Lazy<IDictionaryConverter> _mapper;
        readonly Lazy<Type> _implementationType;
        readonly Lazy<ReadOnlyPropertyCache<T>> _readPropertyCache;
        readonly string _shortName;
        readonly Lazy<ReadWritePropertyCache<T>> _writePropertyCache;

        TypeCache()
        {
            _shortName = typeof(T).GetTypeName();
            _readPropertyCache = new Lazy<ReadOnlyPropertyCache<T>>(() => new ReadOnlyPropertyCache<T>());
            _writePropertyCache = new Lazy<ReadWritePropertyCache<T>>(() => new ReadWritePropertyCache<T>());

            _mapper = new Lazy<IDictionaryConverter>(() => TypeCache.DictionaryConverterCache.GetConverter(typeof(T)));
            _converter = new Lazy<IObjectConverter>(() => TypeCache.ObjectConverterCache.GetConverter(typeof(T)));
            _implementationType = new Lazy<Type>(() => DynamicImplementationBuilder.Shared.GetImplementationType(typeof(T)));
        }

        public static Type ImplementationType => Cached.Metadata.Value.ImplementationType;
        public static IReadOnlyPropertyCache<T> ReadOnlyPropertyCache => Cached.Metadata.Value.ReadOnlyPropertyCache;
        public static IReadWritePropertyCache<T> ReadWritePropertyCache => Cached.Metadata.Value.ReadWritePropertyCache;

        public static string ShortName => Cached.Metadata.Value.ShortName;

        public static IDictionaryConverter Mapper => Cached.Metadata.Value.Mapper;

        Type ITypeCache<T>.ImplementationType => _implementationType.Value;
        IReadOnlyPropertyCache<T> ITypeCache<T>.ReadOnlyPropertyCache => _readPropertyCache.Value;
        IReadWritePropertyCache<T> ITypeCache<T>.ReadWritePropertyCache => _writePropertyCache.Value;

        T ITypeCache<T>.InitializeFromObject(object values)
        {
            if (values == null)
                throw new ArgumentNullException(nameof(values));

            var dictionary = TypeCache.DictionaryConverterCache.GetConverter(values.GetType()).GetDictionary(values);

            return (T) _converter.Value.GetObject(new DictionaryObjectValueProvider(dictionary));
        }

        T ITypeCache<T>.InitializeFromObject<TInput>(TInput value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var dictionary = TypeCache<TInput>.Mapper.GetDictionary(value);

            return (T) _converter.Value.GetObject(new DictionaryObjectValueProvider(dictionary));
        }

        IDictionaryConverter ITypeCache<T>.Mapper => _mapper.Value;

        string ITypeCache<T>.ShortName => _shortName;

        public static T InitializeFromObject(object values)
        {
            return Cached.Metadata.Value.InitializeFromObject(values);
        }

        public static T InitializeFromObject<TInput>(TInput value)
        {
            return Cached.Metadata.Value.InitializeFromObject(value);
        }


        static class Cached
        {
            internal static readonly Lazy<ITypeCache<T>> Metadata = new Lazy<ITypeCache<T>>(() => new TypeCache<T>(),
                LazyThreadSafetyMode.PublicationOnly);
        }
    }
}