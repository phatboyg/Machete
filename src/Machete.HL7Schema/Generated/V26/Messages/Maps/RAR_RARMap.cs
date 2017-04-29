// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RAR_RAR (MessageMap) - 
    /// </summary>
    public class RAR_RARMap :
        HL7TemplateMap<RAR_RAR>
    {
        public RAR_RARMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segments(x => x.ERR, 2);
            Segments(x => x.SFT, 3);
            Segment(x => x.UAC, 4);
            Groups(x => x.Definition, 5, x => x.Required = true);
            Segment(x => x.DSC, 6);
        }
    }
}