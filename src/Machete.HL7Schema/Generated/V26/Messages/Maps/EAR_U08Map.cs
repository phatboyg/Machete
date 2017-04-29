// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// EAR_U08 (MessageMap) - 
    /// </summary>
    public class EAR_U08Map :
        HL7TemplateMap<EAR_U08>
    {
        public EAR_U08Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.EQU, 3, x => x.Required = true);
            Groups(x => x.CommandResponse, 4, x => x.Required = true);
            Segment(x => x.ROL, 5);
        }
    }
}