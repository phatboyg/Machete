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
        HL7V26LayoutMap<OMB_O27_ORDER>
    {
        public OMB_O27_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Segment(x => x.BPO, 2, x => x.Required = true);
            Segment(x => x.SPM, 3);
            Segment(x => x.NTE, 4);
            Segment(x => x.DG1, 5);
            Layout(x => x.Observation, 6);
            Segment(x => x.FT1, 7);
            Segment(x => x.BLG, 8);
        }
    }
}