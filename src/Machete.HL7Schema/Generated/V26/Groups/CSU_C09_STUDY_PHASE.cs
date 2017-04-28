// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// CSU_C09_STUDY_PHASE (Group) - 
    /// </summary>
    public interface CSU_C09_STUDY_PHASE :
        HL7Template
    {
        /// <summary>
        /// CSP
        /// </summary>
        Segment<CSP> CSP { get; }

        /// <summary>
        /// STUDY_SCHEDULE
        /// </summary>
        GroupList<CSU_C09_STUDY_SCHEDULE> StudySchedule { get; }
    }
}