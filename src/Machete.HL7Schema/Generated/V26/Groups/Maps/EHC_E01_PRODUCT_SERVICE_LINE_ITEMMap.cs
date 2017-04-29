// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E01_PRODUCT_SERVICE_LINE_ITEM (GroupMap) - 
    /// </summary>
    public class EHC_E01_PRODUCT_SERVICE_LINE_ITEMMap :
        HL7TemplateMap<EHC_E01_PRODUCT_SERVICE_LINE_ITEM>
    {
        public EHC_E01_PRODUCT_SERVICE_LINE_ITEMMap()
        {
            Segment(x => x.PSL, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
            Segments(x => x.ADJ, 2);
            Segment(x => x.AUT, 3);
            Segments(x => x.LOC, 4);
            Segments(x => x.ROL, 5);
        }
    }
}