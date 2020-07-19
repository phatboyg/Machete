// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// DTN (Component) - Day Type and Number
    /// </summary>
    public interface DTN :
        HL7V26Component
    {
        /// <summary>
        /// DTN-1  Day Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> DayType { get; }

        /// <summary>
        /// DTN-2  Number of Days
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> NumberOfDays { get; }
    }
}