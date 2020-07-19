// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E15_PRODUCT_SERVICE_GROUP (GroupMap) - 
    /// </summary>
    public class EHC_E15_PRODUCT_SERVICE_GROUPMap :
        HL7V26LayoutMap<EHC_E15_PRODUCT_SERVICE_GROUP>
    {
        public EHC_E15_PRODUCT_SERVICE_GROUPMap()
        {
            Segment(x => x.PSG, 0, x => x.Required = true);
            Layout(x => x.PslItemInfo, 1, x => x.Required = true);
        }
    }
}