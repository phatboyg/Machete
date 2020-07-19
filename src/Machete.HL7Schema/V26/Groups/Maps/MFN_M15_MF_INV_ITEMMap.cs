// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M15_MF_INV_ITEM (GroupMap) - 
    /// </summary>
    public class MFN_M15_MF_INV_ITEMMap :
        HL7V26LayoutMap<MFN_M15_MF_INV_ITEM>
    {
        public MFN_M15_MF_INV_ITEMMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.IIM, 1, x => x.Required = true);
        }
    }
}