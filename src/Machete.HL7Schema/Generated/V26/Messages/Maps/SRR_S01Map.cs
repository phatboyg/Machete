// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SRR_S01 (MessageMap) - 
    /// </summary>
    public class SRR_S01Map :
        HL7TemplateMap<SRR_S01>
    {
        public SRR_S01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segments(x => x.ERR, 2);
            Group(x => x.Schedule, 3);
        }
    }
}