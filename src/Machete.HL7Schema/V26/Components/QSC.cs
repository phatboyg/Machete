// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// QSC (Component) - Query Selection Criteria
    /// </summary>
    public interface QSC :
        HL7V26Component
    {
        /// <summary>
        /// QSC-1  Segment Field Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SegmentFieldName { get; }

        /// <summary>
        /// QSC-2  Relational Operator
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> RelationalOperator { get; }

        /// <summary>
        /// QSC-3  Value
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Value { get; }

        /// <summary>
        /// QSC-4  Relational Conjunction
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> RelationalConjunction { get; }
    }
}