// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// WVS (Component) - Waveform Source
    /// </summary>
    public interface WVS :
        HL7V26Component
    {
        /// <summary>
        /// WVS-1  Source One Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SourceOneName { get; }

        /// <summary>
        /// WVS-2  Source Two Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> SourceTwoName { get; }
    }
}