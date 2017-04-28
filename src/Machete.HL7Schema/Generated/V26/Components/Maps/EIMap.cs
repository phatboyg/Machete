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
        HL7ComponentMap<EI>
    {
        public EIMap()
        {
            Value(x => x.EntityIdentifier, 1);
            Value(x => x.NamespaceId, 2);
            Value(x => x.UniversalId, 3);
            Value(x => x.UniversalIdType, 4);
        }
    }
}