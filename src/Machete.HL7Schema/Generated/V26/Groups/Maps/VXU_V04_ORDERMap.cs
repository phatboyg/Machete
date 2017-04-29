// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// VXU_V04_ORDER (GroupMap) - 
    /// </summary>
    public class VXU_V04_ORDERMap :
        HL7TemplateMap<VXU_V04_ORDER>
    {
        public VXU_V04_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Segment(x => x.RXA, 2, x => x.Required = true);
            Segment(x => x.RXR, 3);
            Groups(x => x.Observation, 4);
        }
    }
}