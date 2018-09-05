// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// VR (Component) - Value Range
    /// </summary>
    public interface VR :
        HL7V26Component
    {
        /// <summary>
        /// VR-1  First Data Code Value
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> FirstDataCodeValue { get; }

        /// <summary>
        /// VR-2  Last Data Code Value
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> LastDataCodeValue { get; }
    }
}