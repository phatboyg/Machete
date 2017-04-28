// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORP_O10_ORDER (GroupMap) - 
    /// </summary>
    public class ORP_O10_ORDERMap :
        HL7TemplateMap<ORP_O10_ORDER>
    {
        public ORP_O10_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OrderDetail, 2);
        }
    }
}