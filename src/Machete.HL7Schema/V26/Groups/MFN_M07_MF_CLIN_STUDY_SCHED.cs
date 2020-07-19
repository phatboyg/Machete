// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFN_M07_MF_CLIN_STUDY_SCHED (Group) - 
    /// </summary>
    public interface MFN_M07_MF_CLIN_STUDY_SCHED :
        HL7V26Layout
    {
        /// <summary>
        /// MFE
        /// </summary>
        Segment<MFE> MFE { get; }

        /// <summary>
        /// CM0
        /// </summary>
        Segment<CM0> CM0 { get; }

        /// <summary>
        /// CM2
        /// </summary>
        SegmentList<CM2> CM2 { get; }
    }
}