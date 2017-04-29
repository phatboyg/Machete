// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGV_O15_ORDER_DETAIL_SUPPLEMENT (GroupMap) - 
    /// </summary>
    public class RGV_O15_ORDER_DETAIL_SUPPLEMENTMap :
        HL7TemplateMap<RGV_O15_ORDER_DETAIL_SUPPLEMENT>
    {
        public RGV_O15_ORDER_DETAIL_SUPPLEMENTMap()
        {
            Segments(x => x.NTE, 0, x => x.Required = true);
            Segments(x => x.RXR, 1, x => x.Required = true);
            Groups(x => x.Components, 2);
        }
    }
}