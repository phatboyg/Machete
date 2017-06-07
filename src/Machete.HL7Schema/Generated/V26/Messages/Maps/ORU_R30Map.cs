// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORU_R30 (MessageMap) - 
    /// </summary>
    public class ORU_R30Map :
        HL7V26LayoutMap<ORU_R30>
    {
        public ORU_R30Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.PID, 3, x => x.Required = true);
            Segment(x => x.PD1, 4);
            Segment(x => x.OBX, 5);
            Layout(x => x.Visit, 6);
            Segment(x => x.ORC, 7, x => x.Required = true);
            Segment(x => x.OBR, 8, x => x.Required = true);
            Segment(x => x.NTE, 9);
            Segment(x => x.ROL, 10);
            Layout(x => x.TimingQty, 11);
            Layout(x => x.Observation, 12, x => x.Required = true);
        }
    }
}