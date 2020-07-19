// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORP_O10_ORDER_DETAIL (GroupMap) - 
    /// </summary>
    public class ORP_O10_ORDER_DETAILMap :
        HL7V26LayoutMap<ORP_O10_ORDER_DETAIL>
    {
        public ORP_O10_ORDER_DETAILMap()
        {
            Segment(x => x.RXO, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
            Segment(x => x.RXR, 2, x => x.Required = true);
            Layout(x => x.Component, 3);
        }
    }
}