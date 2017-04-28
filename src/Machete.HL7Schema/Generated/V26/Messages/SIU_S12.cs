// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SIU_S12 (Message) - 
    /// </summary>
    public interface SIU_S12 :
        HL7Template
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

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
        GroupList<SIU_S12_PATIENT> Patient { get; }

        /// <summary>
        /// RESOURCES
        /// </summary>
        GroupList<SIU_S12_RESOURCES> Resources { get; }
    }
}