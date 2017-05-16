// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMN_O07_PATIENT (GroupMap) - 
    /// </summary>
    public class OMN_O07_PATIENTMap :
        HL7LayoutMap<OMN_O07_PATIENT>
    {
        public OMN_O07_PATIENTMap()
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