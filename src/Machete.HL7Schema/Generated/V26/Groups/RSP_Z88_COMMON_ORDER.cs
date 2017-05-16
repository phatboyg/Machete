// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z88_COMMON_ORDER (Group) - 
    /// </summary>
    public interface RSP_Z88_COMMON_ORDER :
        HL7Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<RSP_Z88_TIMING> Timing { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Layout<RSP_Z88_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// ORDER_ENCODED
        /// </summary>
        Layout<RSP_Z88_ORDER_ENCODED> OrderEncoded { get; }

        /// <summary>
        /// RXD
        /// </summary>
        Segment<RXD> RXD { get; }

        /// <summary>
        /// RXR
        /// </summary>
        SegmentList<RXR> RXR { get; }

        /// <summary>
        /// RXC
        /// </summary>
        SegmentList<RXC> RXC { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<RSP_Z88_OBSERVATION> Observation { get; }
    }
}