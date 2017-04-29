// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSU_C09_STUDY_SCHEDULE (GroupMap) - 
    /// </summary>
    public class CSU_C09_STUDY_SCHEDULEMap :
        HL7TemplateMap<CSU_C09_STUDY_SCHEDULE>
    {
        public CSU_C09_STUDY_SCHEDULEMap()
        {
            Segment(x => x.CSS, 0);
            Groups(x => x.StudyObservation, 1, x => x.Required = true);
            Groups(x => x.StudyPharm, 2, x => x.Required = true);
        }
    }
}