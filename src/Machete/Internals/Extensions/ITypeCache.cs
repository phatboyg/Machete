namespace Machete.Internals.Extensions
{
    using Mapping;
    using Reflection;


    public interface ITypeCache<T>
    {
        IDictionaryConverter Mapper { get; }
        string ShortName { get; }
        IReadOnlyPropertyCache<T> ReadOnlyPropertyCache { get; }
        IReadWritePropertyCache<T> ReadWritePropertyCache { get; }

        T InitializeFromObject(object values);
        T InitializeFromObject<TInput>(TInput value);
    }
}