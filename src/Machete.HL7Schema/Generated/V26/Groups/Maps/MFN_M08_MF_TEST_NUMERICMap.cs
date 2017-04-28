// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M08_MF_TEST_NUMERIC (GroupMap) - 
    /// </summary>
    public class MFN_M08_MF_TEST_NUMERICMap :
        HL7TemplateMap<MFN_M08_MF_TEST_NUMERIC>
    {
        public MFN_M08_MF_TEST_NUMERICMap()
        {
            Map(x => x.MFE, 0, x => x.Required = true);
            Map(x => x.OM1, 1, x => x.Required = true);
            Map(x => x.OM2, 2);
            Map(x => x.OM3, 3);
            Map(x => x.OM4, 4);
        }
    }
}