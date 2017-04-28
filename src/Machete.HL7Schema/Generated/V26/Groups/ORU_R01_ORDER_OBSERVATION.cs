// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORU_R01_ORDER_OBSERVATION (Group) - 
    /// </summary>
    public interface ORU_R01_ORDER_OBSERVATION :
        HL7Template
    {
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
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }

        /// <summary>
        /// TIMING_QTY
        /// </summary>
        GroupList<ORU_R01_TIMING_QTY> TimingQty { get; }

        /// <summary>
        /// CTD
        /// </summary>
        Segment<CTD> CTD { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        GroupList<ORU_R01_OBSERVATION> Observation { get; }

        /// <summary>
        /// FT1
        /// </summary>
        SegmentList<FT1> FT1 { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        GroupList<ORU_R01_SPECIMEN> Specimen { get; }
    }
}