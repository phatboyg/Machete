// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// RMC (Component) - Room Coverage
    /// </summary>
    public interface RMC :
        HL7V26Component
    {
        /// <summary>
        /// RMC-1  Room Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> RoomType { get; }

        /// <summary>
        /// RMC-2  Amount Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AmountType { get; }

        /// <summary>
        /// RMC-3  Coverage Amount
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> CoverageAmount { get; }

        /// <summary>
        /// RMC-4  Money or Percentage
        /// </summary>
        /// <returns>The MOP value</returns>
        Value<MOP> MoneyOrPercentage { get; }
    }
}