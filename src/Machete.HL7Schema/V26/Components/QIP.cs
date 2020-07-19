// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// QIP (Component) - Query Input Parameter List
    /// </summary>
    public interface QIP :
        HL7V26Component
    {
        /// <summary>
        /// QIP-1  Segment Field Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SegmentFieldName { get; }

        /// <summary>
        /// QIP-2  Values
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Values { get; }
    }
}