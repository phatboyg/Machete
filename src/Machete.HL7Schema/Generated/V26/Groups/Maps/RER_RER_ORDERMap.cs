// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RER_RER_ORDER (GroupMap) - 
    /// </summary>
    public class RER_RER_ORDERMap :
        HL7TemplateMap<RER_RER_ORDER>
    {
        public RER_RER_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.RXE, 1, x => x.Required = true);
            Map(x => x.RXR, 2, x => x.Required = true);
            Map(x => x.RXC, 3);
        }
    }
}