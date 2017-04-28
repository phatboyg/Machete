// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ADT_A06 (MessageMap) - 
    /// </summary>
    public class ADT_A06Map :
        HL7TemplateMap<ADT_A06>
    {
        public ADT_A06Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EVN, 3, x => x.Required = true);
            Map(x => x.PID, 4, x => x.Required = true);
            Map(x => x.PD1, 5);
            Map(x => x.ARV, 6);
            Map(x => x.ROL, 7);
            Map(x => x.MRG, 8);
            Map(x => x.NK1, 9);
            Map(x => x.PV1, 10, x => x.Required = true);
            Map(x => x.PV2, 11);
            Map(x => x.ARV2, 12);
            Map(x => x.ROL2, 13);
            Map(x => x.DB1, 14);
            Map(x => x.OBX, 15);
            Map(x => x.AL1, 16);
            Map(x => x.DG1, 17);
            Map(x => x.DRG, 18);
            Map(x => x.Procedure, 19);
            Map(x => x.GT1, 20);
            Map(x => x.Insurance, 21);
            Map(x => x.ACC, 22);
            Map(x => x.UB1, 23);
            Map(x => x.UB2, 24);
        }
    }
}