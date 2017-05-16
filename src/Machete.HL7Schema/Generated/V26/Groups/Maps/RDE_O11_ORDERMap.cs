// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDE_O11_ORDER (GroupMap) - 
    /// </summary>
    public class RDE_O11_ORDERMap :
        HL7LayoutMap<RDE_O11_ORDER>
    {
        public RDE_O11_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Layout(x => x.OrderDetail, 2);
            Segment(x => x.RXE, 3, x => x.Required = true);
            Segment(x => x.NTE, 4);
            Layout(x => x.TimingEncoded, 5, x => x.Required = true);
            Segment(x => x.RXR, 6, x => x.Required = true);
            Segment(x => x.RXC, 7);
            Layout(x => x.Observation, 8);
            Segment(x => x.FT1, 9);
            Segment(x => x.BLG, 10);
            Segment(x => x.CTI, 11);
        }
    }
}