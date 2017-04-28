// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OML_O21_ORDER (Group) - 
    /// </summary>
    public interface OML_O21_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<OML_O21_TIMING> Timing { get; }

        /// <summary>
        /// OBSERVATION_REQUEST
        /// </summary>
        Group<OML_O21_OBSERVATION_REQUEST> ObservationRequest { get; }

        /// <summary>
        /// FT1
        /// </summary>
        SegmentList<FT1> FT1 { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }

        /// <summary>
        /// BLG
        /// </summary>
        Segment<BLG> BLG { get; }
    }
}