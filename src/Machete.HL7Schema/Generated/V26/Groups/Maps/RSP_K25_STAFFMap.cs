// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_K25_STAFF (GroupMap) - 
    /// </summary>
    public class RSP_K25_STAFFMap :
        HL7V26LayoutMap<RSP_K25_STAFF>
    {
        public RSP_K25_STAFFMap()
        {
            Segment(x => x.STF, 0, x => x.Required = true);
            Segment(x => x.PRA, 1);
            Segment(x => x.ORG, 2);
            Segment(x => x.AFF, 3);
            Segment(x => x.LAN, 4);
            Segment(x => x.EDU, 5);
            Segment(x => x.CER, 6);
        }
    }
}