namespace Machete.Layouts.Properties
{
    using Entities.EntityProperties;


    public class EntityItemFactory<T> :
        IPropertyListItemFactory<T, Entity<T>>
        where T : Entity
    {
        public Entity<T> CreateMissing()
        {
            return new EntityProperty<T>();
        }

        public Entity<T> Create(T value)
        {
            return new EntityProperty<T>(value);
        }

        public static readonly IPropertyListItemFactory<T, Entity<T>> Factory = new EntityItemFactory<T>();
    }
}