namespace Machete
{
    using Values;


    /// <summary>
    /// An entity list is zero or more entities in a layout.
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    public interface EntityList<TEntity> :
        IEntity
        where TEntity : Entity
    {
        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        Entity<TEntity> this[int index] { get; }

        /// <summary>
        /// Access the value at the specified index
        /// </summary>
        /// <param name="index">The value index</param>
        /// <param name="value">The output value</param>
        /// <returns>True if the value exists, otherwise false.</returns>
        bool TryGetValue(int index, out Entity<TEntity> value);
    }


    public static class EntityList
    {
        public static EntityList<T> Missing<T>()
            where T : Entity
        {
            return Cached<T>.MissingEntityList;
        }


        static class Cached<T>
            where T : Entity
        {
//            public static readonly EntityList<T> EmptyEntityList = GetEmptyValue();
            public static readonly EntityList<T> MissingEntityList = GetMissingValue();

//            static EntityList<T> GetEmptyValue()
//            {
//                return new EmptyEntityList<T>();
//            }

            static EntityList<T> GetMissingValue()
            {
                return new MissingEntityList<T>();
            }
        }
    }
}