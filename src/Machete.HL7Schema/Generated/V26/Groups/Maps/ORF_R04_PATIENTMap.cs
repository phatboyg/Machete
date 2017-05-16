// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORF_R04_PATIENT (GroupMap) - 
    /// </summary>
    public class ORF_R04_PATIENTMap :
        HL7LayoutMap<ORF_R04_PATIENT>
    {
        public ORF_R04_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.OBX, 2);
        }
    }
}