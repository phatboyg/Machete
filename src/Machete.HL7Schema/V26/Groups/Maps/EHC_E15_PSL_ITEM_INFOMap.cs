// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EHC_E15_PSL_ITEM_INFO (GroupMap) - 
    /// </summary>
    public class EHC_E15_PSL_ITEM_INFOMap :
        HL7V26LayoutMap<EHC_E15_PSL_ITEM_INFO>
    {
        public EHC_E15_PSL_ITEM_INFOMap()
        {
            Segment(x => x.PSL, 0, x => x.Required = true);
            Segment(x => x.ADJ, 1);
        }
    }
}