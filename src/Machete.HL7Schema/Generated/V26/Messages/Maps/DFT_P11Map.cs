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
        HL7TemplateMap<DFT_P11>
    {
        public DFT_P11Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EVN, 3, x => x.Required = true);
            Map(x => x.PID, 4, x => x.Required = true);
            Map(x => x.PD1, 5);
            Map(x => x.ROL, 6);
            Map(x => x.PV1, 7);
            Map(x => x.PV2, 8);
            Map(x => x.ROL2, 9);
            Map(x => x.DB1, 10);
            Map(x => x.CommonOrder, 11);
            Map(x => x.DG1, 12);
            Map(x => x.DRG, 13);
            Map(x => x.GT1, 14);
            Map(x => x.Insurance, 15);
            Map(x => x.ACC, 16);
            Map(x => x.Financial, 17, x => x.Required = true);
        }
    }
}