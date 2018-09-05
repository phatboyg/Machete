// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// ERL (Component) - Error Location
    /// </summary>
    public interface ERL :
        HL7V26Component
    {
        /// <summary>
        /// ERL-1  Segment ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SegmentId { get; }

        /// <summary>
        /// ERL-2  Segment Sequence
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> SegmentSequence { get; }

        /// <summary>
        /// ERL-3  Field Position
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> FieldPosition { get; }

        /// <summary>
        /// ERL-4  Field Repetition
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> FieldRepetition { get; }

        /// <summary>
        /// ERL-5  Component Number
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> ComponentNumber { get; }

        /// <summary>
        /// ERL-6  Sub-Component Number
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> SubComponentNumber { get; }
    }
}