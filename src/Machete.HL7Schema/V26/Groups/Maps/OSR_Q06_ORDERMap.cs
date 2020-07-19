// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OSR_Q06_ORDER (GroupMap) - 
    /// </summary>
    public class OSR_Q06_ORDERMap :
        HL7V26LayoutMap<OSR_Q06_ORDER>
    {
        public OSR_Q06_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.IsRequired());
            Layout(x => x.Timing, 1);
            // TODO: need to make this optional as part of Issue #39
            Segment(x => x.OBR, 2, x => x.IsRequired());
            Segment(x => x.NTE, 3);
            Segment(x => x.CTI, 4);
        }
    }
}