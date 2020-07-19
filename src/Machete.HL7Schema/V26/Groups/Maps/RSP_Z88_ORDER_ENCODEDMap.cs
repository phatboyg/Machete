// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Z88_ORDER_ENCODED (GroupMap) - 
    /// </summary>
    public class RSP_Z88_ORDER_ENCODEDMap :
        HL7V26LayoutMap<RSP_Z88_ORDER_ENCODED>
    {
        public RSP_Z88_ORDER_ENCODEDMap()
        {
            Segment(x => x.RXE, 0, x => x.Required = true);
            Layout(x => x.TimingEncoded, 1);
            Segment(x => x.RXR, 2, x => x.Required = true);
            Segment(x => x.RXC, 3);
        }
    }
}