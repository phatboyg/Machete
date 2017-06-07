// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BTS_O31_PRODUCT_STATUS (GroupMap) - 
    /// </summary>
    public class BTS_O31_PRODUCT_STATUSMap :
        HL7V26LayoutMap<BTS_O31_PRODUCT_STATUS>
    {
        public BTS_O31_PRODUCT_STATUSMap()
        {
            Segment(x => x.BTX, 0, x => x.Required = true);
            Segment(x => x.NTE, 1);
        }
    }
}