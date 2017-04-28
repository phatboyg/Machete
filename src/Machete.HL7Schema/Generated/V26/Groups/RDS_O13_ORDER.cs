// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RDS_O13_ORDER (Group) - 
    /// </summary>
    public interface RDS_O13_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<RDS_O13_TIMING> Timing { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Group<RDS_O13_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// ENCODING
        /// </summary>
        Group<RDS_O13_ENCODING> Encoding { get; }

        /// <summary>
        /// RXD
        /// </summary>
        Segment<RXD> RXD { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

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
        GroupList<RDS_O13_OBSERVATION> Observation { get; }

        /// <summary>
        /// FT1
        /// </summary>
        SegmentList<FT1> FT1 { get; }
    }
}