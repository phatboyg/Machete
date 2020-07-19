// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// MOP (Component) - Money or Percentage
    /// </summary>
    public interface MOP :
        HL7V26Component
    {
        /// <summary>
        /// MOP-1  Money or Percentage Indicator
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> MoneyOrPercentageIndicator { get; }

        /// <summary>
        /// MOP-2  Money or Percentage Quantity
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> MoneyOrPercentageQuantity { get; }

        /// <summary>
        /// MOP-3  Currency Denomination
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CurrencyDenomination { get; }
    }
}