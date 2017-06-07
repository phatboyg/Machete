// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// WVI (ComponentMap) - Channel Identifier
    /// </summary>
    public class WVIMap :
        HL7V26ComponentMap<WVI>
    {
        public WVIMap()
        {
            Value(x => x.ChannelNumber, 0);
            Value(x => x.ChannelName, 1);
        }
    }
}