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
        HL7LayoutMap<MFN_M08_MF_TEST_NUMERIC>
    {
        public MFN_M08_MF_TEST_NUMERICMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.OM1, 1, x => x.Required = true);
            Segment(x => x.OM2, 2);
            Segment(x => x.OM3, 3);
            Segment(x => x.OM4, 4);
        }
    }
}