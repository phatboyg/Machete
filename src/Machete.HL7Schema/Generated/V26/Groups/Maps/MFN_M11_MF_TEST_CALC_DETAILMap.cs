// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M11_MF_TEST_CALC_DETAIL (GroupMap) - 
    /// </summary>
    public class MFN_M11_MF_TEST_CALC_DETAILMap :
        HL7LayoutMap<MFN_M11_MF_TEST_CALC_DETAIL>
    {
        public MFN_M11_MF_TEST_CALC_DETAILMap()
        {
            Segment(x => x.OM6, 0, x => x.Required = true);
            Segment(x => x.OM2, 1, x => x.Required = true);
        }
    }
}