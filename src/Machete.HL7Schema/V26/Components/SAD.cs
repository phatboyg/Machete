// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// SAD (Component) - Street Address
    /// </summary>
    public interface SAD :
        HL7V26Component
    {
        /// <summary>
        /// SAD-1  Street or Mailing Address
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> StreetOrMailingAddress { get; }

        /// <summary>
        /// SAD-2  Street Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> StreetName { get; }

        /// <summary>
        /// SAD-3  Dwelling Number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> DwellingNumber { get; }
    }
}