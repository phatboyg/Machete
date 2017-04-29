// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGV_O15_ORDER_DETAIL (GroupMap) - 
    /// </summary>
    public class RGV_O15_ORDER_DETAILMap :
        HL7TemplateMap<RGV_O15_ORDER_DETAIL>
    {
        public RGV_O15_ORDER_DETAILMap()
        {
            Segment(x => x.RXO, 0, x => x.Required = true);
            Group(x => x.OrderDetailSupplement, 1);
        }
    }
}