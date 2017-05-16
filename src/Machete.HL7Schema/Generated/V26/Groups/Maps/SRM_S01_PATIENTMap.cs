// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRM_S01_PATIENT (GroupMap) - 
    /// </summary>
    public class SRM_S01_PATIENTMap :
        HL7LayoutMap<SRM_S01_PATIENT>
    {
        public SRM_S01_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PV1, 1);
            Segment(x => x.PV2, 2);
            Segment(x => x.OBX, 3);
            Segment(x => x.DG1, 4);
        }
    }
}