// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDS_O13_ORDER_DETAIL (GroupMap) - 
    /// </summary>
    public class RDS_O13_ORDER_DETAILMap :
        HL7TemplateMap<RDS_O13_ORDER_DETAIL>
    {
        public RDS_O13_ORDER_DETAILMap()
        {
            Segment(x => x.RXO, 0, x => x.Required = true);
            Group(x => x.OrderDetailSupplement, 1);
        }
    }
}