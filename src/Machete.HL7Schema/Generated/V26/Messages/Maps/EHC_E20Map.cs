// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E20 (MessageMap) - 
    /// </summary>
    public class EHC_E20Map :
        HL7TemplateMap<EHC_E20>
    {
        public EHC_E20Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.IVC, 3, x => x.Required = true);
            Map(x => x.CTD, 4, x => x.Required = true);
            Map(x => x.LOC, 5);
            Map(x => x.ROL, 6);
            Map(x => x.PatInfo, 7, x => x.Required = true);
            Map(x => x.PslItemInfo, 8, x => x.Required = true);
        }
    }
}