// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// BRT_O32_ORDER (Group) - 
    /// </summary>
    public interface BRT_O32_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<BRT_O32_TIMING> Timing { get; }

        /// <summary>
        /// BPO
        /// </summary>
        Segment<BPO> BPO { get; }

        /// <summary>
        /// BTX
        /// </summary>
        SegmentList<BTX> BTX { get; }
    }
}