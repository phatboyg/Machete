// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z86_COMMON_ORDER (GroupMap) - 
    /// </summary>
    public class RSP_Z86_COMMON_ORDERMap :
        HL7TemplateMap<RSP_Z86_COMMON_ORDER>
    {
        public RSP_Z86_COMMON_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OrderDetail, 2);
            Map(x => x.EncodedOrder, 3);
            Map(x => x.Dispense, 4);
            Map(x => x.Give, 5);
            Map(x => x.Administration, 6);
            Map(x => x.Observation, 7, x => x.Required = true);
        }
    }
}