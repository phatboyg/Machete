// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SQR_S25_PATIENT (GroupMap) - 
    /// </summary>
    public class SQR_S25_PATIENTMap :
        HL7V26LayoutMap<SQR_S25_PATIENT>
    {
        public SQR_S25_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PV1, 1);
            Segment(x => x.PV2, 2);
            Segment(x => x.DG1, 3);
        }
    }
}