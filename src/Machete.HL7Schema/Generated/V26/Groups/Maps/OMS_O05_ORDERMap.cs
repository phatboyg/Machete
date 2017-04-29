// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMS_O05_ORDER (GroupMap) - 
    /// </summary>
    public class OMS_O05_ORDERMap :
        HL7TemplateMap<OMS_O05_ORDER>
    {
        public OMS_O05_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Segment(x => x.RQD, 2, x => x.Required = true);
            Segment(x => x.RQ1, 3);
            Segments(x => x.NTE, 4);
            Groups(x => x.Observation, 5);
            Segment(x => x.BLG, 6);
        }
    }
}