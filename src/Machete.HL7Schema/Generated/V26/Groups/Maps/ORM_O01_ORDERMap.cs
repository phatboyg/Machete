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
        HL7TemplateMap<ORM_O01_ORDER>
    {
        public ORM_O01_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Group(x => x.OrderDetail, 1);
            Segments(x => x.FT1, 2);
            Segments(x => x.CTI, 3);
            Segment(x => x.BLG, 4);
        }
    }
}