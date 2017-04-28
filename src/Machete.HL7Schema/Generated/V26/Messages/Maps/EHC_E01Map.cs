// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E01 (MessageMap) - 
    /// </summary>
    public class EHC_E01Map :
        HL7TemplateMap<EHC_E01>
    {
        public EHC_E01Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.IVC, 3, x => x.Required = true);
            Map(x => x.PYE, 4);
            Map(x => x.CTD, 5);
            Map(x => x.AUT, 6);
            Map(x => x.LOC, 7);
            Map(x => x.ROL, 8);
            Map(x => x.ProductServiceSection, 9, x => x.Required = true);
        }
    }
}