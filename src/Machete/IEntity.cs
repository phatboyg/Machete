namespace Machete
{
    using System;


    public interface IEntity
    {
        /// <summary>
        /// The entity type
        /// </summary>
        Type EntityType { get; }
        
        /// <summary>
        /// True if the entity has a value, false if it is a logical NULL
        /// </summary>
        bool HasValue { get; }
    }
}