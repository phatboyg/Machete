// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// SN (Component) - Structured Numeric
    /// </summary>
    public interface SN :
        HL7V26Component
    {
        /// <summary>
        /// SN-1  Comparator
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Comparator { get; }

        /// <summary>
        /// SN-2  Num1
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> Num1 { get; }

        /// <summary>
        /// SN-3  Separator/Suffix
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SeparatorSuffix { get; }

        /// <summary>
        /// SN-4  Num2
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> Num2 { get; }
    }
}