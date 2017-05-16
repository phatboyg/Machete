// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MDM_T02_OBSERVATION (GroupMap) - 
    /// </summary>
    public class MDM_T02_OBSERVATIONMap :
        HL7LayoutMap<MDM_T02_OBSERVATION>
    {
        public MDM_T02_OBSERVATIONMap()
        {
            Segment(x => x.OBX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}