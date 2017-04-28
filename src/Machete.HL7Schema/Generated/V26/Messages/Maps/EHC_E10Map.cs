// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E10 (MessageMap) - 
    /// </summary>
    public class EHC_E10Map :
        HL7TemplateMap<EHC_E10>
    {
        public EHC_E10Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.ERR, 4);
            Map(x => x.InvoiceProcessingResultsInfo, 5, x => x.Required = true);
        }
    }
}