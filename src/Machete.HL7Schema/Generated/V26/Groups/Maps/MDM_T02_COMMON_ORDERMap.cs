// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MDM_T02_COMMON_ORDER (GroupMap) - 
    /// </summary>
    public class MDM_T02_COMMON_ORDERMap :
        HL7TemplateMap<MDM_T02_COMMON_ORDER>
    {
        public MDM_T02_COMMON_ORDERMap()
        {
            Map(x => x.ORC, 0, x => x.Required = true);
            Map(x => x.Timing, 1);
            Map(x => x.OBR, 2, x => x.Required = true);
            Map(x => x.NTE, 3);
        }
    }
}