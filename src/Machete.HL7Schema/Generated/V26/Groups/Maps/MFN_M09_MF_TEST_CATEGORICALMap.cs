// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M09_MF_TEST_CATEGORICAL (GroupMap) - 
    /// </summary>
    public class MFN_M09_MF_TEST_CATEGORICALMap :
        HL7V26LayoutMap<MFN_M09_MF_TEST_CATEGORICAL>
    {
        public MFN_M09_MF_TEST_CATEGORICALMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.OM1, 1, x => x.Required = true);
            Layout(x => x.MfTestCatDetail, 2);
        }
    }
}