namespace Machete
{
    using System;


    public class SchemaEntityInfo :
        EntityInfo
    {
        public SchemaEntityInfo(Type entityType, Type schemaType, IEntitySelector entitySelector, bool isDefined = true)
        {
            EntityType = entityType;
            SchemaType = schemaType;
            IsDefined = isDefined;
            EntitySelector = entitySelector;
        }

        public Type EntityType { get; }
        public Type SchemaType { get; }
        public bool IsDefined { get; }
        public IEntitySelector EntitySelector { get; }
    }
}