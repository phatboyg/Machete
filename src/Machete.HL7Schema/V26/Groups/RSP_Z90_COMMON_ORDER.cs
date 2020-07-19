// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z90_COMMON_ORDER (Group) - 
    /// </summary>
    public interface RSP_Z90_COMMON_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<RSP_Z90_TIMING> Timing { get; }

        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// CTD
        /// </summary>
        Segment<CTD> CTD { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<RSP_Z90_OBSERVATION> Observation { get; }
    }
}