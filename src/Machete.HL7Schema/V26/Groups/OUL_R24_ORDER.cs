// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OUL_R24_ORDER (Group) - 
    /// </summary>
    public interface OUL_R24_ORDER :
        HL7V26Layout
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
        LayoutList<OUL_R24_TIMING_QTY> TimingQty { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        LayoutList<OUL_R24_SPECIMEN> Specimen { get; }

        /// <summary>
        /// RESULT
        /// </summary>
        LayoutList<OUL_R24_RESULT> Result { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }
    }
}