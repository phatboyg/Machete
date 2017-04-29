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
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Group(x => x.OrderDetail, 2);
        }
    }
}