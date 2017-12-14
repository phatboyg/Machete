namespace Machete.Entities
{
    using System;
    using Internals.Extensions;


    public class MissingEntity<T> :
        Entity<T>
        where T : Entity
    {
        public Type EntityType => typeof(T);
        public bool HasValue => false;

        public T Value => throw new EntityMissingException($"The entity {TypeCache<T>.ShortName} is not present.");
    }
}