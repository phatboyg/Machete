// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_E03_INVOICE_PROCESSING_RESULTS_INFO (GroupMap) - 
    /// </summary>
    public class RSP_E03_INVOICE_PROCESSING_RESULTS_INFOMap :
        HL7TemplateMap<RSP_E03_INVOICE_PROCESSING_RESULTS_INFO>
    {
        public RSP_E03_INVOICE_PROCESSING_RESULTS_INFOMap()
        {
            Map(x => x.IPR, 0, x => x.Required = true);
        }
    }
}