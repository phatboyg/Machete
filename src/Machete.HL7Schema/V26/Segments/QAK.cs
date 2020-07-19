// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// QAK (Segment) - Query Acknowledgment
    /// </summary>
    public interface QAK :
        HL7V26Segment
    {
        /// <summary>
        /// QAK-1: Query Tag
        /// </summary>
        Value<string> QueryTag { get; }

        /// <summary>
        /// QAK-2: Query Response Status
        /// </summary>
        Value<string> QueryResponseStatus { get; }

        /// <summary>
        /// QAK-3: Message Query Name
        /// </summary>
        Value<CWE> MessageQueryName { get; }

        /// <summary>
        /// QAK-4: Hit Count Total
        /// </summary>
        Value<decimal> HitCountTotal { get; }

        /// <summary>
        /// QAK-5: This payload
        /// </summary>
        Value<decimal> ThiPayload { get; }

        /// <summary>
        /// QAK-6: Hits remaining
        /// </summary>
        Value<decimal> HitsRemaining { get; }
    }
}