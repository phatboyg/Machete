// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BPS_O29_ORDER (Group) - 
    /// </summary>
    public interface BPS_O29_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<BPS_O29_TIMING> Timing { get; }

        /// <summary>
        /// BPO
        /// </summary>
        Segment<BPO> BPO { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// PRODUCT
        /// </summary>
        GroupList<BPS_O29_PRODUCT> Product { get; }
    }
}