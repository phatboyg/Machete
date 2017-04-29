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
        HL7TemplateMap<ADT_AXX>
    {
        public ADT_AXXMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4);
            Segment(x => x.PD1, 5);
            Segments(x => x.ARV, 6);
            Segments(x => x.ROL, 7);
            Segment(x => x.MRG, 8);
            Segments(x => x.NK1, 9);
            Segment(x => x.PV1, 10);
            Segment(x => x.PV2, 11);
            Segments(x => x.ARV2, 12);
            Segments(x => x.ROL2, 13);
            Segments(x => x.DB1, 14);
            Segments(x => x.OBX, 15);
            Segments(x => x.AL1, 16);
            Segments(x => x.DG1, 17);
            Segment(x => x.DRG, 18);
            Groups(x => x.ADT_AXX_PROCEDURE, 19);
            Segments(x => x.GT1, 20);
            Groups(x => x.ADT_AXX_INSURANCE, 21);
            Segment(x => x.ACC, 22);
            Segment(x => x.UB1, 23);
            Segment(x => x.UB2, 24);
            Segment(x => x.PDA, 25);
            Segment(x => x.PID2, 26);
            Segment(x => x.PD12, 27);
            Segment(x => x.PV12, 28);
            Segment(x => x.PV22, 29);
            Segments(x => x.DB12, 30);
            Segments(x => x.OBX2, 31);
            Segment(x => x.NPU, 32);
            Groups(x => x.ADT_AXX_PATIENT, 33);
            Groups(x => x.ADT_AXX_MERGE_INFO, 34);
            Segments(x => x.IAM, 35);
        }
    }
}