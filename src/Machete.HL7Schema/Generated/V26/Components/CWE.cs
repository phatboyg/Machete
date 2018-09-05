// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// CWE (Component) - Coded with Exceptions
    /// </summary>
    public interface CWE :
        HL7V26Component
    {
        /// <summary>
        /// CWE-1  Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Identifier { get; }

        /// <summary>
        /// CWE-2  Text
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> Text { get; }

        /// <summary>
        /// CWE-3  Name of Coding System
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameOfCodingSystem { get; }

        /// <summary>
        /// CWE-4  Alternate Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateIdentifier { get; }

        /// <summary>
        /// CWE-5  Alternate Text
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateText { get; }

        /// <summary>
        /// CWE-6  Name of Alternate Coding System
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NameOfAlternateCodingSystem { get; }

        /// <summary>
        /// CWE-7  Coding System Version ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> CodingSystemVersionId { get; }

        /// <summary>
        /// CWE-8  Alternate Coding System Version ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> AlternateCodingSystemVersionId { get; }

        /// <summary>
        /// CWE-9  Original Text
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> OriginalText { get; }
    }
}