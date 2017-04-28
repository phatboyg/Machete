// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E21_PSL_ITEM_INFO (GroupMap) - 
    /// </summary>
    public class EHC_E21_PSL_ITEM_INFOMap :
        HL7TemplateMap<EHC_E21_PSL_ITEM_INFO>
    {
        public EHC_E21_PSL_ITEM_INFOMap()
        {
            Map(x => x.PSL, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
            Map(x => x.AUT, 2);
        }
    }
}