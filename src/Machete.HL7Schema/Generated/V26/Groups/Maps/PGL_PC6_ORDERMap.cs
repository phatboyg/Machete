// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PGL_PC6_ORDER (GroupMap) - 
    /// </summary>
    public class PGL_PC6_ORDERMap :
        HL7TemplateMap<PGL_PC6_ORDER>
    {
        public PGL_PC6_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.OrderDetail, 1);
        }
    }
}