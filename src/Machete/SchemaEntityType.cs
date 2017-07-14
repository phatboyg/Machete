namespace Machete
{
    using System;


    public class SchemaEntityType :
        EntityType
    {
        public SchemaEntityType(Type entityType, Type schemaType, IEntityTypeSelector entityTypeSelector, bool isDefined = true)
        {
            EntityType = entityType;
            SchemaType = schemaType;
            IsDefined = isDefined;
            EntityTypeSelector = entityTypeSelector;
        }

        public Type EntityType { get; }
        public Type SchemaType { get; }
        public bool IsDefined { get; }
        public IEntityTypeSelector EntityTypeSelector { get; }
    }
}