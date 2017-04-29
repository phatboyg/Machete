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
        HL7TemplateMap<RSP_K25_STAFF>
    {
        public RSP_K25_STAFFMap()
        {
            Segment(x => x.STF, 0, x => x.Required = true);
            Segments(x => x.PRA, 1);
            Segments(x => x.ORG, 2);
            Segments(x => x.AFF, 3);
            Segments(x => x.LAN, 4);
            Segments(x => x.EDU, 5);
            Segments(x => x.CER, 6);
        }
    }
}