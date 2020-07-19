// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// DFT_P11 (MessageMap) - 
    /// </summary>
    public class DFT_P11Map :
        HL7V26LayoutMap<DFT_P11>
    {
        public DFT_P11Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PD1, 5);
            Segment(x => x.ROL, 6);
            Segment(x => x.PV1, 7);
            Segment(x => x.PV2, 8);
            Segment(x => x.ROL2, 9);
            Segment(x => x.DB1, 10);
            Layout(x => x.CommonOrder, 11);
            Segment(x => x.DG1, 12);
            Segment(x => x.DRG, 13);
            Segment(x => x.GT1, 14);
            Layout(x => x.Insurance, 15);
            Segment(x => x.ACC, 16);
            Layout(x => x.Financial, 17, x => x.Required = true);
        }
    }
}