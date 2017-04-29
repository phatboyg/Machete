// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BRT_O32_RESPONSE (GroupMap) - 
    /// </summary>
    public class BRT_O32_RESPONSEMap :
        HL7TemplateMap<BRT_O32_RESPONSE>
    {
        public BRT_O32_RESPONSEMap()
        {
            Segment(x => x.PID, 0);
            Groups(x => x.Order, 1);
        }
    }
}