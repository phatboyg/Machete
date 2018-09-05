// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// VID (Component) - Version Identifier
    /// </summary>
    public interface VID :
        HL7V26Component
    {
        /// <summary>
        /// VID-1  Version ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> VersionId { get; }

        /// <summary>
        /// VID-2  Internationalization Code
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> InternationalizationCode { get; }

        /// <summary>
        /// VID-3  International Version ID
        /// </summary>
        /// <returns>The CWE value</returns>
        Value<CWE> InternationalVersionId { get; }
    }
}