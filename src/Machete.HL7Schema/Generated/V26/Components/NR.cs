// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// NR (Component) - Numeric Range
    /// </summary>
    public interface NR :
        HL7V26Component
    {
        /// <summary>
        /// NR-1  Low Value
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> LowValue { get; }

        /// <summary>
        /// NR-2  High Value
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> HighValue { get; }
    }
}