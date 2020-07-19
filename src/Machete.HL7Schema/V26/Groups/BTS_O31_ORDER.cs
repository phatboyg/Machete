// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BTS_O31_ORDER (Group) - 
    /// </summary>
    public interface BTS_O31_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<BTS_O31_TIMING> Timing { get; }

        /// <summary>
        /// BPO
        /// </summary>
        Segment<BPO> BPO { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// PRODUCT_STATUS
        /// </summary>
        LayoutList<BTS_O31_PRODUCT_STATUS> ProductStatus { get; }
    }
}