// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPU_R25_PATIENT (GroupMap) - 
    /// </summary>
    public class OPU_R25_PATIENTMap :
        HL7V26LayoutMap<OPU_R25_PATIENT>
    {
        public OPU_R25_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Layout(x => x.PatientObservation, 2);
        }
    }
}