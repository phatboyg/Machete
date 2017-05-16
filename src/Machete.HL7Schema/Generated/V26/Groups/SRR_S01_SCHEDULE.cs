// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SRR_S01_SCHEDULE (Group) - 
    /// </summary>
    public interface SRR_S01_SCHEDULE :
        HL7Layout
    {
        /// <summary>
        /// SCH
        /// </summary>
        Segment<SCH> SCH { get; }

        /// <summary>
        /// TQ1
        /// </summary>
        SegmentList<TQ1> TQ1 { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        LayoutList<SRR_S01_PATIENT> Patient { get; }

        /// <summary>
        /// RESOURCES
        /// </summary>
        LayoutList<SRR_S01_RESOURCES> Resources { get; }
    }
}