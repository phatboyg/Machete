// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CP (Component) - Composite Price
    /// </summary>
    public interface CP :
        HL7V26Component
    {
        /// <summary>
        /// CP-1  Price
        /// </summary>
        /// <returns>The MO value</returns>
        Value<MO> Price { get; }

        /// <summary>
        /// CP-2  Price Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> PriceType { get; }

        /// <summary>
        /// CP-3  From Value
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> FromValue { get; }

        /// <summary>
        /// CP-4  To Value
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> ToValue { get; }

        /// <summary>
        /// CP-5  Range Units
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> RangeUnits { get; }

        /// <summary>
        /// CP-6  Range Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> RangeType { get; }
    }
}