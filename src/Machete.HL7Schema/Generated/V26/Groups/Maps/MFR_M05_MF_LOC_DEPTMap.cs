// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFR_M05_MF_LOC_DEPT (GroupMap) - 
    /// </summary>
    public class MFR_M05_MF_LOC_DEPTMap :
        HL7TemplateMap<MFR_M05_MF_LOC_DEPT>
    {
        public MFR_M05_MF_LOC_DEPTMap()
        {
            Segment(x => x.LDP, 0, x => x.Required = true);
            Segments(x => x.LCH, 1);
            Segments(x => x.LCC, 2);
        }
    }
}