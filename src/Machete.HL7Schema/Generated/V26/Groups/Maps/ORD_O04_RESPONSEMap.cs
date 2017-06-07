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
        HL7V26LayoutMap<ORD_O04_RESPONSE>
    {
        public ORD_O04_RESPONSEMap()
        {
            Layout(x => x.Patient, 0);
            Layout(x => x.OrderDiet, 1, x => x.Required = true);
            Layout(x => x.OrderTray, 2);
        }
    }
}