// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CNE (Component) - Coded with No Exceptions
    /// </summary>
    public interface CNE :
        HL7V26Component
    {
        /// <summary>
        /// CNE-1  Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Identifier { get; }

        /// <summary>
        /// CNE-2  Text
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Text { get; }

        /// <summary>
        /// CNE-3  Name of Coding System
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameOfCodingSystem { get; }

        /// <summary>
        /// CNE-4  Alternate Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateIdentifier { get; }

        /// <summary>
        /// CNE-5  Alternate Text
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateText { get; }

        /// <summary>
        /// CNE-6  Name of Alternate Coding System
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameOfAlternateCodingSystem { get; }

        /// <summary>
        /// CNE-7  Coding System Version ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CodingSystemVersionId { get; }

        /// <summary>
        /// CNE-8  Alternate Coding System Version ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateCodingSystemVersionId { get; }

        /// <summary>
        /// CNE-9  Original Text
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OriginalText { get; }
    }
}