// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SUR_P09_PRODUCT (GroupMap) - 
    /// </summary>
    public class SUR_P09_PRODUCTMap :
        HL7TemplateMap<SUR_P09_PRODUCT>
    {
        public SUR_P09_PRODUCTMap()
        {
            Segment(x => x.PSH, 0, x => x.Required = true);
            Segment(x => x.PDC, 1, x => x.Required = true);
        }
    }
}