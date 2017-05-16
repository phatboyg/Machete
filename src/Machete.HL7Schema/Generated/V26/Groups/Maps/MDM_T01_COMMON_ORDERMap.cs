// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MDM_T01_COMMON_ORDER (GroupMap) - 
    /// </summary>
    public class MDM_T01_COMMON_ORDERMap :
        HL7LayoutMap<MDM_T01_COMMON_ORDER>
    {
        public MDM_T01_COMMON_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Segment(x => x.OBR, 2, x => x.Required = true);
            Segment(x => x.NTE, 3);
        }
    }
}