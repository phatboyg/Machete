// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z86_ENCODED_ORDER (GroupMap) - 
    /// </summary>
    public class RSP_Z86_ENCODED_ORDERMap :
        HL7TemplateMap<RSP_Z86_ENCODED_ORDER>
    {
        public RSP_Z86_ENCODED_ORDERMap()
        {
            Segment(x => x.RXE, 0, x => x.Required = true);
            Groups(x => x.TimingEncoded, 1);
            Segments(x => x.RXR, 2, x => x.Required = true);
            Segments(x => x.RXC, 3);
        }
    }
}