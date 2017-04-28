// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E13 (MessageMap) - 
    /// </summary>
    public class EHC_E13Map :
        HL7TemplateMap<EHC_E13>
    {
        public EHC_E13Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.ERR, 4);
            Map(x => x.RFI, 5, x => x.Required = true);
            Map(x => x.CTD, 6);
            Map(x => x.IVC, 7, x => x.Required = true);
            Map(x => x.PSS, 8, x => x.Required = true);
            Map(x => x.PSG, 9, x => x.Required = true);
            Map(x => x.PID, 10);
            Map(x => x.PSL, 11);
            Map(x => x.Request, 12, x => x.Required = true);
        }
    }
}