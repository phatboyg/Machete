// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ROR_ROR_ORDER (GroupMap) - 
    /// </summary>
    public class ROR_ROR_ORDERMap :
        HL7V26LayoutMap<ROR_ROR_ORDER>
    {
        public ROR_ROR_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Segment(x => x.RXO, 1, x => x.Required = true);
            Segment(x => x.RXR, 2, x => x.Required = true);
            Segment(x => x.RXC, 3);
        }
    }
}