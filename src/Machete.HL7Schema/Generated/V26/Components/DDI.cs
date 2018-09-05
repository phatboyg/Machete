// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// DDI (Component) - Daily Deductible Information
    /// </summary>
    public interface DDI :
        HL7V26Component
    {
        /// <summary>
        /// DDI-1  Delay Days
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> DelayDays { get; }

        /// <summary>
        /// DDI-2  Monetary Amount
        /// </summary>
        /// <returns>The MO value</returns>
        Value<MO> MonetaryAmount { get; }

        /// <summary>
        /// DDI-3  Number of Days
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> NumberOfDays { get; }
    }
}