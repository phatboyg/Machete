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
        HL7V26LayoutMap<BPS_O29_ORDER>
    {
        public BPS_O29_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Layout(x => x.Timing, 1);
            Segment(x => x.BPO, 2, x => x.Required = true);
            Segment(x => x.NTE, 3);
            Layout(x => x.Product, 4);
        }
    }
}