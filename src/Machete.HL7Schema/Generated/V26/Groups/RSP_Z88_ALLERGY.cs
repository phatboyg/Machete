// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// RSP_Z88_ALLERGY (Group) - 
    /// </summary>
    public interface RSP_Z88_ALLERGY :
        HL7Template
    {
        /// <summary>
        /// AL1
        /// </summary>
        SegmentList<AL1> AL1 { get; }

        /// <summary>
        /// VISIT
        /// </summary>
        Group<RSP_Z88_VISIT> Visit { get; }
    }
}