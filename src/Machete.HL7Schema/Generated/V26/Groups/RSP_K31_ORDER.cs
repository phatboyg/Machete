// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_K31_ORDER (Group) - 
    /// </summary>
    public interface RSP_K31_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<RSP_K31_TIMING> Timing { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Group<RSP_K31_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// ENCODING
        /// </summary>
        Group<RSP_K31_ENCODING> Encoding { get; }

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
        GroupList<RSP_K31_OBSERVATION> Observation { get; }
    }
}