// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VID (ComponentMap) - Version Identifier
    /// </summary>
    public class VIDMap :
        HL7ComponentMap<VID>
    {
        public VIDMap()
        {
            Value(x => x.VersionId, 0);
            Entity(x => x.InternationalizationCode, 1);
            Entity(x => x.InternationalVersionId, 2);
        }
    }
}