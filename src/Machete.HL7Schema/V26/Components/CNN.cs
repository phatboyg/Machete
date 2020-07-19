// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CNN (Component) - Composite ID Number and Name Simplified
    /// </summary>
    public interface CNN :
        HL7V26Component
    {
        /// <summary>
        /// CNN-1  ID Number
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> IdNumber { get; }

        /// <summary>
        /// CNN-2  Family Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> FamilyName { get; }

        /// <summary>
        /// CNN-3  Given Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> GivenName { get; }

        /// <summary>
        /// CNN-4  Second and Further Given Names or Initials Thereof
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SecondAndFurtherGivenNamesOrInitialsThereof { get; }

        /// <summary>
        /// CNN-5  Suffix (e.g., JR or III)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Suffix { get; }

        /// <summary>
        /// CNN-6  Prefix (e.g., DR)
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Prefix { get; }

        /// <summary>
        /// CNN-7  Degree (e.g., MD
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Degree { get; }

        /// <summary>
        /// CNN-8  Source Table
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SourceTable { get; }

        /// <summary>
        /// CNN-9  Assigning Authority   - Namespace ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AssigningAuthorityNamespaceId { get; }

        /// <summary>
        /// CNN-10  Assigning Authority  - Universal ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AssigningAuthorityUniversalId { get; }

        /// <summary>
        /// CNN-11  Assigning Authority  - Universal ID Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AssigningAuthorityUniversalIdType { get; }
    }
}