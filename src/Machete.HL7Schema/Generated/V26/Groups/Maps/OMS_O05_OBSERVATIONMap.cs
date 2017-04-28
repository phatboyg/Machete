// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMS_O05_OBSERVATION (GroupMap) - 
    /// </summary>
    public class OMS_O05_OBSERVATIONMap :
        HL7TemplateMap<OMS_O05_OBSERVATION>
    {
        public OMS_O05_OBSERVATIONMap()
        {
            Map(x => x.OBX, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}