namespace Machete
{
    public class EntityPropertyFactory<T> :
        IListPropertyFactory<T, Entity<T>>
        where T : Entity
    {
        public Entity<T> CreateProperty()
        {
            return new EntityProperty<T>();
        }

        public Entity<T> CreateProperty(T value)
        {
            return new EntityProperty<T>(value);
        }

        public static readonly IListPropertyFactory<T, Entity<T>> Factory = new EntityPropertyFactory<T>();
    }
}