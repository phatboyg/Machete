// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORM_O01_ORDER (GroupMap) - 
    /// </summary>
    public class ORM_O01_ORDERMap :
        HL7LayoutMap<ORM_O01_ORDER>
    {
        public ORM_O01_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.OrderDetail, 1);
            Segment(x => x.FT1, 2);
            Segment(x => x.CTI, 3);
            Segment(x => x.BLG, 4);
        }
    }
}