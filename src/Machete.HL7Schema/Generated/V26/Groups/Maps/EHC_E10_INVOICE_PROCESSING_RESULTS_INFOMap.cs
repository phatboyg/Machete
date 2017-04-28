// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E10_INVOICE_PROCESSING_RESULTS_INFO (GroupMap) - 
    /// </summary>
    public class EHC_E10_INVOICE_PROCESSING_RESULTS_INFOMap :
        HL7TemplateMap<EHC_E10_INVOICE_PROCESSING_RESULTS_INFO>
    {
        public EHC_E10_INVOICE_PROCESSING_RESULTS_INFOMap()
        {
            Map(x => x.IPR, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.PYE, 2, x => x.Required = true);
            Map(x => x.IN1, 3, x => x.Required = true);
            Map(x => x.IN2, 4);
            Map(x => x.IVC, 5, x => x.Required = true);
            Map(x => x.ProductServiceSection, 6, x => x.Required = true);
        }
    }
}