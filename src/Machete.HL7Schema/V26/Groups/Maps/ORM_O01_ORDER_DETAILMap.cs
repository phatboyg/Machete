// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORM_O01_ORDER_DETAIL (GroupMap) - 
    /// </summary>
    public class ORM_O01_ORDER_DETAILMap :
        HL7V26LayoutMap<ORM_O01_ORDER_DETAIL>
    {
        public ORM_O01_ORDER_DETAILMap()
        {
            // TODO: need to make this optional as part of Issue #39
            Segment(x => x.OBR, 0, x => x.IsRequired());
            Segment(x => x.NTE, 1);
            Segment(x => x.CTD, 2);
            Segment(x => x.DG1, 3);
            Layout(x => x.Observation, 4);
        }
    }
}