// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M10_MF_TEST_BATT_DETAIL (GroupMap) - 
    /// </summary>
    public class MFN_M10_MF_TEST_BATT_DETAILMap :
        HL7TemplateMap<MFN_M10_MF_TEST_BATT_DETAIL>
    {
        public MFN_M10_MF_TEST_BATT_DETAILMap()
        {
            Map(x => x.OM5, 0, x => x.Required = true);
            Map(x => x.OM4, 1);
        }
    }
}