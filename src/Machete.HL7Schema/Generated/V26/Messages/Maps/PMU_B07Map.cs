// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PMU_B07 (MessageMap) - 
    /// </summary>
    public class PMU_B07Map :
        HL7LayoutMap<PMU_B07>
    {
        public PMU_B07Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EVN, 3, x => x.Required = true);
            Segment(x => x.STF, 4, x => x.Required = true);
            Segment(x => x.PRA, 5);
            Layout(x => x.Certificate, 6);
        }
    }
}