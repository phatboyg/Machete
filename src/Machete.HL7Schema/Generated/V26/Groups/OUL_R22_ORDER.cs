// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OUL_R22_ORDER (Group) - 
    /// </summary>
    public interface OUL_R22_ORDER :
        HL7Template
    {
        /// <summary>
        /// OBR
        /// </summary>
        Segment<OBR> OBR { get; }

        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// TIMING_QTY
        /// </summary>
        GroupList<OUL_R22_TIMING_QTY> TimingQty { get; }

        /// <summary>
        /// RESULT
        /// </summary>
        GroupList<OUL_R22_RESULT> Result { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }
    }
}