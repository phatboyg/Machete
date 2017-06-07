// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// CSU_C09_STUDY_SCHEDULE (Group) - 
    /// </summary>
    public interface CSU_C09_STUDY_SCHEDULE :
        HL7V26Layout
    {
        /// <summary>
        /// CSS
        /// </summary>
        Segment<CSS> CSS { get; }

        /// <summary>
        /// STUDY_OBSERVATION
        /// </summary>
        LayoutList<CSU_C09_STUDY_OBSERVATION> StudyObservation { get; }

        /// <summary>
        /// STUDY_PHARM
        /// </summary>
        LayoutList<CSU_C09_STUDY_PHARM> StudyPharm { get; }
    }
}