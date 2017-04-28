// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPL_O37_SPECIMEN (Group) - 
    /// </summary>
    public interface OPL_O37_SPECIMEN :
        HL7Template
    {
        /// <summary>
        /// SPM
        /// </summary>
        Segment<SPM> SPM { get; }

        /// <summary>
        /// OBX
        /// </summary>
        SegmentList<OBX> OBX { get; }

        /// <summary>
        /// CONTAINER
        /// </summary>
        GroupList<OPL_O37_CONTAINER> Container { get; }

        /// <summary>
        /// OBSERVATION_REQUEST
        /// </summary>
        GroupList<OPL_O37_OBSERVATION_REQUEST> ObservationRequest { get; }
    }
}