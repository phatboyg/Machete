// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// ORL_O36_ORDER (Group) - 
    /// </summary>
    public interface ORL_O36_ORDER :
        HL7Template
    {
        /// <summary>
        /// ORC
        /// </summary>
        Segment<ORC> ORC { get; }

        /// <summary>
        /// TIMING
        /// </summary>
        GroupList<ORL_O36_TIMING> Timing { get; }

        /// <summary>
        /// OBSERVATION_REQUEST
        /// </summary>
        Group<ORL_O36_OBSERVATION_REQUEST> ObservationRequest { get; }
    }
}