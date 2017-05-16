// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_K31_ORDER (GroupMap) - 
    /// </summary>
    public class RSP_K31_ORDERMap :
        HL7LayoutMap<RSP_K31_ORDER>
    {
        public RSP_K31_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Layout(x => x.OrderDetail, 2);
            Layout(x => x.Encoding, 3);
            Segment(x => x.RXD, 4, x => x.Required = true);
            Segment(x => x.RXR, 5, x => x.Required = true);
            Segment(x => x.RXC, 6);
            Layout(x => x.Observation, 7, x => x.Required = true);
        }
    }
}