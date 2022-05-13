namespace Machete.Internals.Reflection
{
    using System.Collections.Generic;


    public interface IReadOnlyPropertyCache<T> :
        IEnumerable<ReadOnlyProperty<T>>
    {
        bool TryGetValue(string key, out ReadOnlyProperty<T> value);
    }
}