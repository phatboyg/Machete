// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EI (ComponentMap) - Entity Identifier
    /// </summary>
    public class EIMap :
        HL7V26ComponentMap<EI>
    {
        public EIMap()
        {
            Value(x => x.EntityIdentifier, 0);
            Value(x => x.NamespaceId, 1);
            Value(x => x.UniversalId, 2);
            Value(x => x.UniversalIdType, 3);
        }
    }
}