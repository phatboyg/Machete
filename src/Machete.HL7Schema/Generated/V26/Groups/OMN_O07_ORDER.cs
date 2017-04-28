// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMN_O07_ORDER (Group) - 
    /// </summary>
    public interface OMN_O07_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<OMN_O07_TIMING> Timing { get; }

        /// <summary>
        /// RQD
        /// </summary>
        Segment<RQD> RQD { get; }

        /// <summary>
        /// RQ1
        /// </summary>
        Segment<RQ1> RQ1 { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// OBSERVATION
        /// </summary>
        GroupList<OMN_O07_OBSERVATION> Observation { get; }

        /// <summary>
        /// BLG
        /// </summary>
        Segment<BLG> BLG { get; }
    }
}