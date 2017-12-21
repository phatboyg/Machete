namespace Machete.SchemaConfiguration
{
    using System;
    using System.Collections.Generic;


    public class SchemaEntityInfo :
        EntityInfo
    {
        readonly IDictionary<string, ValueInfo> _valueInfos;

        public SchemaEntityInfo(Type entityType, Type schemaType, IEntitySelector entitySelector, IDictionary<string, ValueInfo> valueInfos, bool isDefined = true)
        {
            _valueInfos = valueInfos;
            EntityType = entityType;
            SchemaType = schemaType;
            IsDefined = isDefined;
            EntitySelector = entitySelector;
        }

        public Type EntityType { get; }
        public Type SchemaType { get; }
        public bool IsDefined { get; }
        public IEntitySelector EntitySelector { get; }

        public bool TryGetValueInfo(string propertyName, out ValueInfo valueInfo)
        {
            return _valueInfos.TryGetValue(propertyName, out valueInfo);
        }
    }
}