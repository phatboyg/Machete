// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// MSG (Component) - Message Type
    /// </summary>
    public interface MSG :
        HL7V26Component
    {
        /// <summary>
        /// MSG-1  Message Code
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> MessageCode { get; }

        /// <summary>
        /// MSG-2  Trigger Event
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> TriggerEvent { get; }

        /// <summary>
        /// MSG-3  Message Structure
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> MessageStructure { get; }
    }
}