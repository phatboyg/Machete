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
        HL7TemplateMap<RGR_RGR_ORDER>
    {
        public RGR_RGR_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Group(x => x.Encoding, 1);
            Segments(x => x.RXG, 2, x => x.Required = true);
            Segments(x => x.RXR, 3, x => x.Required = true);
            Segments(x => x.RXC, 4);
        }
    }
}