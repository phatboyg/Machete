// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// PTA (Component) - Policy Type and Amount
    /// </summary>
    public interface PTA :
        HL7V26Component
    {
        /// <summary>
        /// PTA-1  Policy Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PolicyType { get; }

        /// <summary>
        /// PTA-2  Amount Class
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AmountClass { get; }

        /// <summary>
        /// PTA-3  Money or Percentage Quantity
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> MoneyOrPercentageQuantity { get; }

        /// <summary>
        /// PTA-4  Money or Percentage
        /// </summary>
        /// <returns>The MOP value</returns>
        Value<MOP> MoneyOrPercentage { get; }
    }
}