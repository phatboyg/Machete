// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// XON (Component) - Extended Composite Name and Identification Number for Organizations
    /// </summary>
    public interface XON :
        HL7V26Component
    {
        /// <summary>
        /// XON-1  Organization Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OrganizationName { get; }

        /// <summary>
        /// XON-2  Organization Name Type Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OrganizationNameTypeCode { get; }

        /// <summary>
        /// XON-3  ID Number
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> IdNumber { get; }

        /// <summary>
        /// XON-4  Identifier Check Digit
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> IdentifierCheckDigit { get; }

        /// <summary>
        /// XON-5  Check Digit Scheme
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CheckDigitScheme { get; }

        /// <summary>
        /// XON-6  Assigning Authority
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> AssigningAuthority { get; }

        /// <summary>
        /// XON-7  Identifier Type Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdentifierTypeCode { get; }

        /// <summary>
        /// XON-8  Assigning Facility
        /// </summary>
        /// <returns>The HD value</returns>
        Value<HD> AssigningFacility { get; }

        /// <summary>
        /// XON-9  Name Representation Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameRepresentationCode { get; }

        /// <summary>
        /// XON-10  Organization Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OrganizationIdentifier { get; }
    }
}