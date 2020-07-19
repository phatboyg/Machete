// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// QID (Segment) - Query Identification
    /// </summary>
    public interface QID :
        HL7V26Segment
    {
        /// <summary>
        /// QID-1: Query Tag
        /// </summary>
        Value<string> QueryTag { get; }

        /// <summary>
        /// QID-2: Message Query Name
        /// </summary>
        Value<CWE> MessageQueryName { get; }
    }
}