// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Q11_MF_LOC_DEPT (GroupMap) - 
    /// </summary>
    public class RSP_Q11_MF_LOC_DEPTMap :
        HL7V26LayoutMap<RSP_Q11_MF_LOC_DEPT>
    {
        public RSP_Q11_MF_LOC_DEPTMap()
        {
            Segment(x => x.LDP, 0, x => x.Required = true);
            Segment(x => x.LCH, 1);
            Segment(x => x.LCC, 2);
        }
    }
}