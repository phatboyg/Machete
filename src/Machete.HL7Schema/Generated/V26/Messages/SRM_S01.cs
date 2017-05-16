// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// SRM_S01 (Message) - 
    /// </summary>
    public interface SRM_S01 :
        HL7Layout
    {
        /// <summary>
        /// MSH
        /// </summary>
        Segment<MSH> MSH { get; }

        /// <summary>
        /// ARQ
        /// </summary>
        Segment<ARQ> ARQ { get; }

        /// <summary>
        /// APR
        /// </summary>
        Segment<APR> APR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// PATIENT
        /// </summary>
        LayoutList<SRM_S01_PATIENT> Patient { get; }

        /// <summary>
        /// RESOURCES
        /// </summary>
        LayoutList<SRM_S01_RESOURCES> Resources { get; }
    }
}