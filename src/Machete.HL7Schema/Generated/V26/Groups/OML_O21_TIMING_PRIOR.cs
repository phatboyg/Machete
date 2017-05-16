// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// OML_O21_TIMING_PRIOR (Group) - 
    /// </summary>
    public interface OML_O21_TIMING_PRIOR :
        HL7Layout
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