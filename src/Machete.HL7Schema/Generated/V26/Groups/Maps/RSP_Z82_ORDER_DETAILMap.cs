// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z82_ORDER_DETAIL (GroupMap) - 
    /// </summary>
    public class RSP_Z82_ORDER_DETAILMap :
        HL7TemplateMap<RSP_Z82_ORDER_DETAIL>
    {
        public RSP_Z82_ORDER_DETAILMap()
        {
            Segment(x => x.RXO, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.RXR, 2, x => x.Required = true);
            Group(x => x.Treatment, 3);
        }
    }
}