// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PMU_B03 (MessageMap) - 
    /// </summary>
    public class PMU_B03Map :
        HL7V26LayoutMap<PMU_B03>
    {
        public PMU_B03Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.STF, 4, x => x.Required = true);
        }
    }
}