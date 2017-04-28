// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BPS_O29_ORDER (GroupMap) - 
    /// </summary>
    public class BPS_O29_ORDERMap :
        HL7TemplateMap<BPS_O29_ORDER>
    {
        public BPS_O29_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.BPO, 2, x => x.Required = true);
            Map(x => x.NTE, 3);
            Map(x => x.Product, 4);
        }
    }
}