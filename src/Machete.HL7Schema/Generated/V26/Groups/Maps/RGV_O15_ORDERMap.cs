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
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OrderDetail, 2);
            Map(x => x.Encoding, 3);
            Map(x => x.Give, 4, x => x.Required = true);
        }
    }
}