// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E01_INVOICE_PROCESSING (GroupMap) - 
    /// </summary>
    public class EHC_E01_INVOICE_PROCESSINGMap :
        HL7LayoutMap<EHC_E01_INVOICE_PROCESSING>
    {
        public EHC_E01_INVOICE_PROCESSINGMap()
        {
            Segment(x => x.IPR, 0, x => x.Required = true);
        }
    }
}