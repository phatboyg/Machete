// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ESU_U01 (MessageMap) - 
    /// </summary>
    public class ESU_U01Map :
        HL7TemplateMap<ESU_U01>
    {
        public ESU_U01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EQU, 3, x => x.Required = true);
            Segments(x => x.ISD, 4);
            Segment(x => x.ROL, 5);
        }
    }
}