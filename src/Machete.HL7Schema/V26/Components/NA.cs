// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// NA (Component) - Numeric Array
    /// </summary>
    public interface NA :
        HL7V26Component
    {
        /// <summary>
        /// NA-1  Value1
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> Value1 { get; }

        /// <summary>
        /// NA-2  Value2
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> Value2 { get; }

        /// <summary>
        /// NA-3  Value3
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> Value3 { get; }

        /// <summary>
        /// NA-4  Value4
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> Value4 { get; }
    }
}