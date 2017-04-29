// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDR_RDR_ORDER (GroupMap) - 
    /// </summary>
    public class RDR_RDR_ORDERMap :
        HL7TemplateMap<RDR_RDR_ORDER>
    {
        public RDR_RDR_ORDERMap()
        {
            Segment(x => x.ORC, 0, x => x.Required = true);
            Group(x => x.Encoding, 1);
            Groups(x => x.Dispense, 2, x => x.Required = true);
        }
    }
}