// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// CSU_C09_PATIENT (Group) - 
    /// </summary>
    public interface CSU_C09_PATIENT :
        HL7V26Layout
    {
        /// <summary>
        /// PID
        /// </summary>
        Segment<PID> PID { get; }

        /// <summary>
        /// PD1
        /// </summary>
        Segment<PD1> PD1 { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// VISIT
        /// </summary>
        Layout<CSU_C09_VISIT> Visit { get; }

        /// <summary>
        /// CSR
        /// </summary>
        Segment<CSR> CSR { get; }

        /// <summary>
        /// STUDY_PHASE
        /// </summary>
        LayoutList<CSU_C09_STUDY_PHASE> StudyPhase { get; }
    }
}