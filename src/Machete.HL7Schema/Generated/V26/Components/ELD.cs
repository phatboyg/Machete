// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ELD (Component) - Error Location and Description
    /// </summary>
    public interface ELD :
        HL7V26Component
    {
        /// <summary>
        /// ELD-1  Segment ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SegmentId { get; }

        /// <summary>
        /// ELD-2  Segment Sequence
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> SegmentSequence { get; }

        /// <summary>
        /// ELD-3  Field Position
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> FieldPosition { get; }

        /// <summary>
        /// ELD-4  Code Identifying Error
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> CodeIdentifyingError { get; }
    }
}