// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAR_RAR_ORDER (GroupMap) - 
    /// </summary>
    public class RAR_RAR_ORDERMap :
        HL7TemplateMap<RAR_RAR_ORDER>
    {
        public RAR_RAR_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Encoding, 1);
            Map(x => x.RXA, 2, x => x.Required = true);
            Map(x => x.RXR, 3, x => x.Required = true);
        }
    }
}