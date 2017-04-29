// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORG_O20 (MessageMap) - 
    /// </summary>
    public class ORG_O20Map :
        HL7TemplateMap<ORG_O20>
    {
        public ORG_O20Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segments(x => x.ERR, 2);
            Segments(x => x.SFT, 3);
            Segment(x => x.UAC, 4);
            Segments(x => x.NTE, 5);
            Group(x => x.Response, 6);
        }
    }
}