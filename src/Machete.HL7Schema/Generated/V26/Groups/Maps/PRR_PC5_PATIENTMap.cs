// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PRR_PC5_PATIENT (GroupMap) - 
    /// </summary>
    public class PRR_PC5_PATIENTMap :
        HL7V26LayoutMap<PRR_PC5_PATIENT>
    {
        public PRR_PC5_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Layout(x => x.PatientVisit, 1);
            Layout(x => x.Problem, 2, x => x.Required = true);
        }
    }
}