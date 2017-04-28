// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z82_COMMON_ORDER (Group) - 
    /// </summary>
    public interface RSP_Z82_COMMON_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<RSP_Z82_TIMING> Timing { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Group<RSP_Z82_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// ENCODED_ORDER
        /// </summary>
        Group<RSP_Z82_ENCODED_ORDER> EncodedOrder { get; }

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
        GroupList<RSP_Z82_OBSERVATION> Observation { get; }
    }
}