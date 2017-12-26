namespace Machete.Internals.Extensions
{
    using System;
    using Mapping;
    using Reflection;


    public interface ITypeCache<T>
    {
        IDictionaryConverter Mapper { get; }
        string ShortName { get; }
        Type ImplementationType { get; }

        IReadOnlyPropertyCache<T> ReadOnlyPropertyCache { get; }
        IReadWritePropertyCache<T> ReadWritePropertyCache { get; }

        T InitializeFromObject(object values);
        T InitializeFromObject<TInput>(TInput value);
    }
}