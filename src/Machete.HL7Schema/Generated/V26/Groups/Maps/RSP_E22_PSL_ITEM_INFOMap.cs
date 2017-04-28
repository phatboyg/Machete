// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_E22_PSL_ITEM_INFO (GroupMap) - 
    /// </summary>
    public class RSP_E22_PSL_ITEM_INFOMap :
        HL7TemplateMap<RSP_E22_PSL_ITEM_INFO>
    {
        public RSP_E22_PSL_ITEM_INFOMap()
        {
            Map(x => x.PSL, 0, x => x.Required = true);
        }
    }
}