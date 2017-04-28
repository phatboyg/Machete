// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z82_VISIT (Group) - 
    /// </summary>
    public interface RSP_Z82_VISIT :
        HL7Template
    {
        /// <summary>
        /// AL1
        /// </summary>
        SegmentList<AL1> AL1 { get; }

        /// <summary>
        /// PV1
        /// </summary>
        Segment<PV1> PV1 { get; }

        /// <summary>
        /// PV2
        /// </summary>
        Segment<PV2> PV2 { get; }
    }
}