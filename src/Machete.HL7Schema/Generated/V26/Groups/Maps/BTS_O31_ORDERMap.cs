// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BTS_O31_ORDER (GroupMap) - 
    /// </summary>
    public class BTS_O31_ORDERMap :
        HL7TemplateMap<BTS_O31_ORDER>
    {
        public BTS_O31_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.BPO, 2, x => x.Required = true);
            Map(x => x.NTE, 3);
            Map(x => x.ProductStatus, 4);
        }
    }
}