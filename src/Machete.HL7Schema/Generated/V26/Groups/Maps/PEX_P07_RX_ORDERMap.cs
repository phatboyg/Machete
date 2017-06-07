// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PEX_P07_RX_ORDER (GroupMap) - 
    /// </summary>
    public class PEX_P07_RX_ORDERMap :
        HL7V26LayoutMap<PEX_P07_RX_ORDER>
    {
        public PEX_P07_RX_ORDERMap()
        {
            Segment(x => x.RXE, 0, x => x.Required = true);
            Layout(x => x.TimingQty, 1, x => x.Required = true);
            Segment(x => x.RXR, 2);
        }
    }
}