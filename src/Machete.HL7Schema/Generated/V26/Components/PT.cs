// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// PT (Component) - Processing Type
    /// </summary>
    public interface PT :
        HL7V26Component
    {
        /// <summary>
        /// PT-1  Processing ID
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ProcessingId { get; }

        /// <summary>
        /// PT-2  Processing Mode
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ProcessingMode { get; }
    }
}