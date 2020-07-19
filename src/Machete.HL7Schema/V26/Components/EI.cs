// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// EI (Component) - Entity Identifier
    /// </summary>
    public interface EI :
        HL7V26Component
    {
        /// <summary>
        /// EI-1  Entity Identifier
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> EntityIdentifier { get; }

        /// <summary>
        /// EI-2  Namespace ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NamespaceId { get; }

        /// <summary>
        /// EI-3  Universal ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> UniversalId { get; }

        /// <summary>
        /// EI-4  Universal ID Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> UniversalIdType { get; }
    }
}