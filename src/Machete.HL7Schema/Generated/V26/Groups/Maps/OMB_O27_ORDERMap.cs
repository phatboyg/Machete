// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMB_O27_ORDER (GroupMap) - 
    /// </summary>
    public class OMB_O27_ORDERMap :
        HL7TemplateMap<OMB_O27_ORDER>
    {
        public OMB_O27_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Segment(x => x.BPO, 2, x => x.Required = true);
            Segment(x => x.SPM, 3);
            Segments(x => x.NTE, 4);
            Segments(x => x.DG1, 5);
            Groups(x => x.Observation, 6);
            Segments(x => x.FT1, 7);
            Segment(x => x.BLG, 8);
        }
    }
}