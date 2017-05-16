// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// TCU_U10_TEST_CONFIGURATION (GroupMap) - 
    /// </summary>
    public class TCU_U10_TEST_CONFIGURATIONMap :
        HL7LayoutMap<TCU_U10_TEST_CONFIGURATION>
    {
        public TCU_U10_TEST_CONFIGURATIONMap()
        {
            Segment(x => x.SPM, 0);
            Segment(x => x.TCC, 1, x => x.Required = true);
        }
    }
}