// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OUL_R21_ORDER_OBSERVATION (Group) - 
    /// </summary>
    public interface OUL_R21_ORDER_OBSERVATION :
        HL7Template
    {
        /// <summary>
        /// CONTAINER
        /// </summary>
        Group<OUL_R21_CONTAINER> Container { get; }

        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// TIMING_QTY
        /// </summary>
        GroupList<OUL_R21_TIMING_QTY> TimingQty { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        GroupList<OUL_R21_OBSERVATION> Observation { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }
    }
}