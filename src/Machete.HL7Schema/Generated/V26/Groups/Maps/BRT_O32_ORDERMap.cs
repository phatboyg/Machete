// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BRT_O32_ORDER (GroupMap) - 
    /// </summary>
    public class BRT_O32_ORDERMap :
        HL7TemplateMap<BRT_O32_ORDER>
    {
        public BRT_O32_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Groups(x => x.Timing, 1);
            Segment(x => x.BPO, 2);
            Segments(x => x.BTX, 3);
        }
    }
}