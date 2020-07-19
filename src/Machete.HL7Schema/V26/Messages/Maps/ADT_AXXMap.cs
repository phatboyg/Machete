// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_AXX (MessageMap) - 
    /// </summary>
    public class ADT_AXXMap :
        HL7V26LayoutMap<ADT_AXX>
    {
        public ADT_AXXMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4);
            Segment(x => x.PD1, 5);
            Segment(x => x.ARV, 6);
            Segment(x => x.ROL, 7);
            Segment(x => x.MRG, 8);
            Segment(x => x.NK1, 9);
            Segment(x => x.PV1, 10);
            Segment(x => x.PV2, 11);
            Segment(x => x.ARV2, 12);
            Segment(x => x.ROL2, 13);
            Segment(x => x.DB1, 14);
            Segment(x => x.OBX, 15);
            Segment(x => x.AL1, 16);
            Segment(x => x.DG1, 17);
            Segment(x => x.DRG, 18);
            Layout(x => x.ADT_AXX_PROCEDURE, 19);
            Segment(x => x.GT1, 20);
            Layout(x => x.ADT_AXX_INSURANCE, 21);
            Segment(x => x.ACC, 22);
            Segment(x => x.UB1, 23);
            Segment(x => x.UB2, 24);
            Segment(x => x.PDA, 25);
            Segment(x => x.PID2, 26);
            Segment(x => x.PD12, 27);
            Segment(x => x.PV12, 28);
            Segment(x => x.PV22, 29);
            Segment(x => x.DB12, 30);
            Segment(x => x.OBX2, 31);
            Segment(x => x.NPU, 32);
            Layout(x => x.ADT_AXX_PATIENT, 33);
            Layout(x => x.ADT_AXX_MERGE_INFO, 34);
            Segment(x => x.IAM, 35);
        }
    }
}