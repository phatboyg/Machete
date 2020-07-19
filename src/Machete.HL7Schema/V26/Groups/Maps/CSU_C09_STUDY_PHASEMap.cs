// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSU_C09_STUDY_PHASE (GroupMap) - 
    /// </summary>
    public class CSU_C09_STUDY_PHASEMap :
        HL7V26LayoutMap<CSU_C09_STUDY_PHASE>
    {
        public CSU_C09_STUDY_PHASEMap()
        {
            Segment(x => x.CSP, 0);
            Layout(x => x.StudySchedule, 1, x => x.Required = true);
        }
    }
}