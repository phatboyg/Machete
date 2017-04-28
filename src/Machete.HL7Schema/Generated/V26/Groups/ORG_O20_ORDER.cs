// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORG_O20_ORDER (Group) - 
    /// </summary>
    public interface ORG_O20_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<ORG_O20_TIMING> Timing { get; }

        /// <summary>
        /// OBSERVATION_GROUP
        /// </summary>
        Group<ORG_O20_OBSERVATION_GROUP> ObservationGroup { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// CTI
        /// </summary>
        SegmentList<CTI> CTI { get; }

        /// <summary>
        /// SPECIMEN
        /// </summary>
        GroupList<ORG_O20_SPECIMEN> Specimen { get; }
    }
}