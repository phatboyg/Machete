// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPT_PCL_PATIENT (GroupMap) - 
    /// </summary>
    public class PPT_PCL_PATIENTMap :
        HL7LayoutMap<PPT_PCL_PATIENT>
    {
        public PPT_PCL_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Layout(x => x.PatientVisit, 1);
            Layout(x => x.Pathway, 2, x => x.Required = true);
        }
    }
}