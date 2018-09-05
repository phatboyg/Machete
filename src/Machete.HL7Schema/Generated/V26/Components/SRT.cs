// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// SRT (Component) - Sort Order
    /// </summary>
    public interface SRT :
        HL7V26Component
    {
        /// <summary>
        /// SRT-1  Sort-by Field
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SortByField { get; }

        /// <summary>
        /// SRT-2  Sequencing
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Sequencing { get; }
    }
}