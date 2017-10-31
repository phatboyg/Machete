namespace Machete.Entities
{
    using System;


    public class MissingEntity<T> :
        Entity<T>
        where T : Entity
    {
        public Type EntityType => typeof(T);
        public bool HasValue => false;

        public T Value => throw new EntityMissingException("The entity is missing.");
    }
}