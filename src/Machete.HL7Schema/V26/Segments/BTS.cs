// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// BTS (Segment) - Batch Trailer
    /// </summary>
    public interface BTS :
        HL7V26Segment
    {
        /// <summary>
        /// BTS-1: Batch Message Count
        /// </summary>
        Value<string> BatchMessageCount { get; }

        /// <summary>
        /// BTS-2: Batch Comment
        /// </summary>
        Value<string> BatchComment { get; }

        /// <summary>
        /// BTS-3: Batch Totals
        /// </summary>
        ValueList<decimal> BatchTotals { get; }
    }
}