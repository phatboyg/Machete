// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OMN_O07_TIMING (Group) - 
    /// </summary>
    public interface OMN_O07_TIMING :
        HL7Template
    {
        /// <summary>
        /// TQ1
        /// </summary>
        Segment<TQ1> TQ1 { get; }

        /// <summary>
        /// TQ2
        /// </summary>
        SegmentList<TQ2> TQ2 { get; }
    }
}