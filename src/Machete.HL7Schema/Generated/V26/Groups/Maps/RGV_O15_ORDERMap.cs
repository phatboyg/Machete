// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGV_O15_ORDER (GroupMap) - 
    /// </summary>
    public class RGV_O15_ORDERMap :
        HL7TemplateMap<RGV_O15_ORDER>
    {
        public RGV_O15_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Group(x => x.OrderDetail, 2);
            Group(x => x.Encoding, 3);
            Groups(x => x.Give, 4, x => x.Required = true);
        }
    }
}