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
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EVN, 3, x => x.Required = true);
            Map(x => x.PID, 4);
            Map(x => x.PD1, 5);
            Map(x => x.ARV, 6);
            Map(x => x.ROL, 7);
            Map(x => x.MRG, 8);
            Map(x => x.NK1, 9);
            Map(x => x.PV1, 10);
            Map(x => x.PV2, 11);
            Map(x => x.ARV2, 12);
            Map(x => x.ROL2, 13);
            Map(x => x.DB1, 14);
            Map(x => x.OBX, 15);
            Map(x => x.AL1, 16);
            Map(x => x.DG1, 17);
            Map(x => x.DRG, 18);
            Map(x => x.ADT_AXX_PROCEDURE, 19);
            Map(x => x.GT1, 20);
            Map(x => x.ADT_AXX_INSURANCE, 21);
            Map(x => x.ACC, 22);
            Map(x => x.UB1, 23);
            Map(x => x.UB2, 24);
            Map(x => x.PDA, 25);
            Map(x => x.PID2, 26);
            Map(x => x.PD12, 27);
            Map(x => x.PV12, 28);
            Map(x => x.PV22, 29);
            Map(x => x.DB12, 30);
            Map(x => x.OBX2, 31);
            Map(x => x.NPU, 32);
            Map(x => x.ADT_AXX_PATIENT, 33);
            Map(x => x.ADT_AXX_MERGE_INFO, 34);
            Map(x => x.IAM, 35);
        }
    }
}