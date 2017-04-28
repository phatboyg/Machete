// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E24 (MessageMap) - 
    /// </summary>
    public class EHC_E24Map :
        HL7TemplateMap<EHC_E24>
    {
        public EHC_E24Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.ERR, 4);
            Map(x => x.IVC, 5, x => x.Required = true);
            Map(x => x.PslItemInfo, 6, x => x.Required = true);
        }
    }
}