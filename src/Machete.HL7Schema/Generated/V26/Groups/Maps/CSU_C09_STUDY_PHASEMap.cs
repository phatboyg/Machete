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
        HL7TemplateMap<CSU_C09_STUDY_PHASE>
    {
        public CSU_C09_STUDY_PHASEMap()
        {
            Map(x => x.CSP, 0);
            Map(x => x.StudySchedule, 1, x => x.Required = true);
        }
    }
}