// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORM_O01_INSURANCE (GroupMap) - 
    /// </summary>
    public class ORM_O01_INSURANCEMap :
        HL7V26LayoutMap<ORM_O01_INSURANCE>
    {
        public ORM_O01_INSURANCEMap()
        {
            Segment(x => x.IN1, 0, x => x.IsRequired());
            Segment(x => x.IN2, 1);
            Segment(x => x.IN3, 2);
        }
    }
}