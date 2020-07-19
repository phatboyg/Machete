// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMB_O27_PATIENT (GroupMap) - 
    /// </summary>
    public class OMB_O27_PATIENTMap :
        HL7V26LayoutMap<OMB_O27_PATIENT>
    {
        public OMB_O27_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Segment(x => x.NTE, 2);
            Layout(x => x.PatientVisit, 3);
            Layout(x => x.Insurance, 4);
            Segment(x => x.GT1, 5);
            Segment(x => x.AL1, 6);
        }
    }
}