// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORR_O02_ORDER (GroupMap) - 
    /// </summary>
    public class ORR_O02_ORDERMap :
        HL7V26LayoutMap<ORR_O02_ORDER>
    {
        public ORR_O02_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.IsRequired());
            // TODO: need to make this optional as part of Issue #39
            Segment(x => x.OBR, 1, x => x.IsRequired());
            Segment(x => x.NTE, 2);
            Segment(x => x.CTI, 3);
        }
    }
}