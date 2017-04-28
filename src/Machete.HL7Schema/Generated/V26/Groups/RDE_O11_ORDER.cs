// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RDE_O11_ORDER (Group) - 
    /// </summary>
    public interface RDE_O11_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<RDE_O11_TIMING> Timing { get; }

        /// <summary>
        /// ORDER_DETAIL
        /// </summary>
        Group<RDE_O11_ORDER_DETAIL> OrderDetail { get; }

        /// <summary>
        /// RXE
        /// </summary>
        Segment<RXE> RXE { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// TIMING_ENCODED
        /// </summary>
        GroupList<RDE_O11_TIMING_ENCODED> TimingEncoded { get; }

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
        GroupList<RDE_O11_OBSERVATION> Observation { get; }

        /// <summary>
        /// FT1
        /// </summary>
        SegmentList<FT1> FT1 { get; }

        /// <summary>
        /// BLG
        /// </summary>
        Segment<BLG> BLG { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }
    }
}