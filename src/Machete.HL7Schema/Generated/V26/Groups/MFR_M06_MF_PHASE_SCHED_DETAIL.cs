// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MFR_M06_MF_PHASE_SCHED_DETAIL (Group) - 
    /// </summary>
    public interface MFR_M06_MF_PHASE_SCHED_DETAIL :
        HL7V26Layout
    {
        /// <summary>
        /// CM1
        /// </summary>
        Segment<CM1> CM1 { get; }

        /// <summary>
        /// CM2
        /// </summary>
        SegmentList<CM2> CM2 { get; }
    }
}