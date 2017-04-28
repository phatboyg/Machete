// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E04_PRODUCT_SERVICE_SECTION (GroupMap) - 
    /// </summary>
    public class EHC_E04_PRODUCT_SERVICE_SECTIONMap :
        HL7TemplateMap<EHC_E04_PRODUCT_SERVICE_SECTION>
    {
        public EHC_E04_PRODUCT_SERVICE_SECTIONMap()
        {
            Map(x => x.PSS, 0, x => x.Required = true);
            Map(x => x.ProductServiceGroup, 1);
        }
    }
}