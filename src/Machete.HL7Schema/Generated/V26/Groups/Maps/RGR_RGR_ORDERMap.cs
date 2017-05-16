// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RGR_RGR_ORDER (GroupMap) - 
    /// </summary>
    public class RGR_RGR_ORDERMap :
        HL7LayoutMap<RGR_RGR_ORDER>
    {
        public RGR_RGR_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Encoding, 1);
            Segment(x => x.RXG, 2, x => x.Required = true);
            Segment(x => x.RXR, 3, x => x.Required = true);
            Segment(x => x.RXC, 4);
        }
    }
}