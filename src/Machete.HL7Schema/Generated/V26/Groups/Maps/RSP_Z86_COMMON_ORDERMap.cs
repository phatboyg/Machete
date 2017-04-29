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
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Group(x => x.OrderDetail, 2);
            Group(x => x.EncodedOrder, 3);
            Group(x => x.Dispense, 4);
            Group(x => x.Give, 5);
            Group(x => x.Administration, 6);
            Groups(x => x.Observation, 7, x => x.Required = true);
        }
    }
}