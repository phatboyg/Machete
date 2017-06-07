// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M09_MF_TEST_CAT_DETAIL (GroupMap) - 
    /// </summary>
    public class MFN_M09_MF_TEST_CAT_DETAILMap :
        HL7V26LayoutMap<MFN_M09_MF_TEST_CAT_DETAIL>
    {
        public MFN_M09_MF_TEST_CAT_DETAILMap()
        {
            Segment(x => x.OM3, 0, x => x.Required = true);
            Segment(x => x.OM4, 1);
        }
    }
}