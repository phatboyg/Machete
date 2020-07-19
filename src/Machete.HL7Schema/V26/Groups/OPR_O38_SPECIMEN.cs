// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OPR_O38_SPECIMEN (Group) - 
    /// </summary>
    public interface OPR_O38_SPECIMEN :
        HL7V26Layout
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
        /// SAC
        /// </summary>
        SegmentList<SAC> SAC { get; }

        /// <summary>
        /// OBSERVATION_REQUEST
        /// </summary>
        LayoutList<OPR_O38_OBSERVATION_REQUEST> ObservationRequest { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        LayoutList<OPR_O38_TIMING> Timing { get; }
    }
}