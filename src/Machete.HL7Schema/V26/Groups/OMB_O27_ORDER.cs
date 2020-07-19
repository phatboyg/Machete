// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMB_O27_ORDER (Group) - 
    /// </summary>
    public interface OMB_O27_ORDER :
        HL7V26Layout
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<OMB_O27_TIMING> Timing { get; }

        /// <summary>
        /// BPO
        /// </summary>
        Segment<BPO> BPO { get; }

        /// <summary>
        /// SPM
        /// </summary>
        Segment<SPM> SPM { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// DG1
        /// </summary>
        SegmentList<DG1> DG1 { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        LayoutList<OMB_O27_OBSERVATION> Observation { get; }

        /// <summary>
        /// FT1
        /// </summary>
        SegmentList<FT1> FT1 { get; }

        /// <summary>
        /// BLG
        /// </summary>
        Segment<BLG> BLG { get; }
    }
}