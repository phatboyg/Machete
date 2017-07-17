namespace Machete
{
    using System;


    public interface EntityInfo
    {
        /// <summary>
        /// The schema entity type
        /// </summary>
        Type EntityType { get; }
        
        /// <summary>
        /// The schema type containing this entity
        /// </summary>
        Type SchemaType { get; }

        /// <summary>
        /// True if the entity is defined by the schema
        /// </summary>
        bool IsDefined { get; }

        /// <summary>
        /// The entity type selector for this entity
        /// </summary>
        IEntitySelector EntitySelector { get; }
    }
}