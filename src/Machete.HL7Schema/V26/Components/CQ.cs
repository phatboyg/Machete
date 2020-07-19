// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CQ (Component) - Composite Quantity with Units
    /// </summary>
    public interface CQ :
        HL7V26Component
    {
        /// <summary>
        /// CQ-1  Quantity
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> Quantity { get; }

        /// <summary>
        /// CQ-2  Units
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> Units { get; }
    }
}