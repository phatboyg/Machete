namespace Machete.Entities
{
    using System;


    public class MissingEntity<T> :
        Entity<T>
        where T : Entity
    {
        public Type EntityType => typeof(T);
        public bool IsPresent => false;
        public bool HasValue => false;

        public T Value
        {
            get { throw new EntityMissingException("The entity is missing."); }
        }
    }
}