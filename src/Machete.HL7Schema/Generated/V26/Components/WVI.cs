// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    /// <summary>
    /// WVI (Component) - Channel Identifier
    /// </summary>
    public interface WVI :
        HL7V26Component
    {
        /// <summary>
        /// WVI-1  Channel Number
        /// </summary>
        /// <returns>The decimal value</returns>
        Value<decimal> ChannelNumber { get; }

        /// <summary>
        /// WVI-2  Channel Name
        /// </summary>
        /// <returns>The string value</returns>
        Value<string> ChannelName { get; }
    }
}