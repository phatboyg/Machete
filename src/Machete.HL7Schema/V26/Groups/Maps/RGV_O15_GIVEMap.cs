// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGV_O15_GIVE (GroupMap) - 
    /// </summary>
    public class RGV_O15_GIVEMap :
        HL7V26LayoutMap<RGV_O15_GIVE>
    {
        public RGV_O15_GIVEMap()
        {
            Segment(x => x.RXG, 0, x => x.Required = true);
            Layout(x => x.TimingGive, 1, x => x.Required = true);
            Segment(x => x.RXR, 2, x => x.Required = true);
            Segment(x => x.RXC, 3);
            Layout(x => x.Observation, 4, x => x.Required = true);
        }
    }
}