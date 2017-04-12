namespace Machete
{
    using System;


    public interface EntityType
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
        /// True if the entity isn't recognized by the schema
        /// </summary>
        bool IsUnknown { get; }

        /// <summary>
        /// The entity type selector for this entity
        /// </summary>
        IEntityTypeSelector EntityTypeSelector { get; }
    }
}