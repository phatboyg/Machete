// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MSG (ComponentMap) - Message Type
    /// </summary>
    public class MSGMap :
        HL7ComponentMap<MSG>
    {
        public MSGMap()
        {
            Value(x => x.MessageCode, 0);
            Value(x => x.TriggerEvent, 1);
            Value(x => x.MessageStructure, 2);
        }
    }
}