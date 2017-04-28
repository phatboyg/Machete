// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// MDM_T01_COMMON_ORDER (Group) - 
    /// </summary>
    public interface MDM_T01_COMMON_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<MDM_T01_TIMING> Timing { get; }

        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }
    }
}