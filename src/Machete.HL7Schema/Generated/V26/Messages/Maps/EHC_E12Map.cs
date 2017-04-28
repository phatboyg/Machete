// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E12 (MessageMap) - 
    /// </summary>
    public class EHC_E12Map :
        HL7TemplateMap<EHC_E12>
    {
        public EHC_E12Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.RFI, 3, x => x.Required = true);
            Map(x => x.CTD, 4);
            Map(x => x.IVC, 5, x => x.Required = true);
            Map(x => x.PSS, 6, x => x.Required = true);
            Map(x => x.PSG, 7, x => x.Required = true);
            Map(x => x.PID, 8);
            Map(x => x.PSL, 9);
            Map(x => x.Request, 10, x => x.Required = true);
        }
    }
}