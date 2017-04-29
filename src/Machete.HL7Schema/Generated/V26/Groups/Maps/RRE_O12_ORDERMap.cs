// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRE_O12_ORDER (GroupMap) - 
    /// </summary>
    public class RRE_O12_ORDERMap :
        HL7TemplateMap<RRE_O12_ORDER>
    {
        public RRE_O12_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Group(x => x.Encoding, 2);
        }
    }
}