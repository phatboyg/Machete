// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// HD (Component) - Hierarchic Designator
    /// </summary>
    public interface HD :
        HL7V26Component
    {
        /// <summary>
        /// HD-1  Namespace ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> NamespaceId { get; }

        /// <summary>
        /// HD-2  Universal ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> UniversalId { get; }

        /// <summary>
        /// HD-3  Universal ID Type
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> UniversalIdType { get; }
    }
}