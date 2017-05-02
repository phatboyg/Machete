// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// HD (ComponentMap) - Hierarchic Designator
    /// </summary>
    public class HDMap :
        HL7ComponentMap<HD>
    {
        public HDMap()
        {
            Value(x => x.NamespaceId, 0);
            Value(x => x.UniversalId, 1);
            Value(x => x.UniversalIdType, 2);
        }
    }
}