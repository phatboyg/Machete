namespace Machete
{
    using System;


    public class SchemaEntityType :
        EntityType
    {
        public SchemaEntityType(Type entityType, Type schemaType, IEntityTypeSelector entityTypeSelector, bool isUnknown = false)
        {
            EntityType = entityType;
            SchemaType = schemaType;
            IsUnknown = isUnknown;
            EntityTypeSelector = entityTypeSelector;
        }

        public Type EntityType { get; }
        public Type SchemaType { get; }
        public bool IsUnknown { get; }
        public IEntityTypeSelector EntityTypeSelector { get; }
    }
}