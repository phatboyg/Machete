// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BPS_O29_PRODUCT (GroupMap) - 
    /// </summary>
    public class BPS_O29_PRODUCTMap :
        HL7TemplateMap<BPS_O29_PRODUCT>
    {
        public BPS_O29_PRODUCTMap()
        {
            Segment(x => x.BPX, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}