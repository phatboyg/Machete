// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A03 (MessageMap) - 
    /// </summary>
    public class ADT_A03Map :
        HL7LayoutMap<ADT_A03>
    {
        public ADT_A03Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.PID, 4, x => x.Required = true);
            Segment(x => x.PD1, 5);
            Segment(x => x.ARV, 6);
            Segment(x => x.ROL, 7);
            Segment(x => x.NK1, 8);
            Segment(x => x.PV1, 9, x => x.Required = true);
            Segment(x => x.PV2, 10);
            Segment(x => x.ARV2, 11);
            Segment(x => x.ROL2, 12);
            Segment(x => x.DB1, 13);
            Segment(x => x.AL1, 14);
            Segment(x => x.DG1, 15);
            Segment(x => x.DRG, 16);
            Layout(x => x.Procedure, 17);
            Segment(x => x.OBX, 18);
            Segment(x => x.GT1, 19);
            Layout(x => x.Insurance, 20);
            Segment(x => x.ACC, 21);
            Segment(x => x.PDA, 22);
        }
    }
}