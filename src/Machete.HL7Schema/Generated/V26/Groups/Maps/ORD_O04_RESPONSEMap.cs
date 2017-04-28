// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORD_O04_RESPONSE (GroupMap) - 
    /// </summary>
    public class ORD_O04_RESPONSEMap :
        HL7TemplateMap<ORD_O04_RESPONSE>
    {
        public ORD_O04_RESPONSEMap()
        {
            Map(x => x.Patient, 0);
            Map(x => x.OrderDiet, 1, x => x.Required = true);
            Map(x => x.OrderTray, 2);
        }
    }
}