// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMN_O07_OBSERVATION (GroupMap) - 
    /// </summary>
    public class OMN_O07_OBSERVATIONMap :
        HL7TemplateMap<OMN_O07_OBSERVATION>
    {
        public OMN_O07_OBSERVATIONMap()
        {
            Map(x => x.OBX, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}