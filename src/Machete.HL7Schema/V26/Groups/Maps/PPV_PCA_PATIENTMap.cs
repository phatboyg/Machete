// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPV_PCA_PATIENT (GroupMap) - 
    /// </summary>
    public class PPV_PCA_PATIENTMap :
        HL7V26LayoutMap<PPV_PCA_PATIENT>
    {
        public PPV_PCA_PATIENTMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Layout(x => x.PatientVisit, 1);
            Layout(x => x.Goal, 2, x => x.Required = true);
        }
    }
}