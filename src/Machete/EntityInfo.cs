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
        /// True if the entity is defined by the schema
        /// </summary>
        bool IsDefined { get; }

        /// <summary>
        /// The entity type selector for this entity
        /// </summary>
        IEntitySelector EntitySelector { get; }

        /// <summary>
        /// Return the ValueInfo for the specified property
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="valueInfo"></param>
        /// <returns></returns>
        bool TryGetValueInfo(string propertyName, out ValueInfo valueInfo);
    }
}