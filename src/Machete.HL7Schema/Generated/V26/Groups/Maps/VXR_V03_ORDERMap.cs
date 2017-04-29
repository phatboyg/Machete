// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXR_V03_ORDER (GroupMap) - 
    /// </summary>
    public class VXR_V03_ORDERMap :
        HL7TemplateMap<VXR_V03_ORDER>
    {
        public VXR_V03_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Segment(x => x.RXA, 2, x => x.Required = true);
            Segment(x => x.RXR, 3);
            Groups(x => x.Observation, 4);
        }
    }
}