// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E01_PRODUCT_SERVICE_GROUP (GroupMap) - 
    /// </summary>
    public class EHC_E01_PRODUCT_SERVICE_GROUPMap :
        HL7TemplateMap<EHC_E01_PRODUCT_SERVICE_GROUP>
    {
        public EHC_E01_PRODUCT_SERVICE_GROUPMap()
        {
            Map(x => x.PSG, 0, x => x.Required = true);
            Map(x => x.LOC, 1);
            Map(x => x.ROL, 2);
            Map(x => x.PatientInfo, 3);
            Map(x => x.ProductServiceLineItem, 4, x => x.Required = true);
            Map(x => x.Procedure, 5);
            Map(x => x.InvoiceProcessing, 6);
        }
    }
}