namespace Machete
{
    public interface GroupList<TEntity> :
        IValue
        where TEntity : Entity
    {
        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        Group<TEntity> this[int index] { get; }

        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        /// <param name="value">The output value</param>
        /// <returns>True if the value exists, otherwise false.</returns>
        bool TryGetValue(int index, out Group<TEntity> value);
    }
}