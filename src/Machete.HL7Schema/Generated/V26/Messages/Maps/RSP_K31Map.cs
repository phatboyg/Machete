// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_K31 (MessageMap) - 
    /// </summary>
    public class RSP_K31Map :
        HL7TemplateMap<RSP_K31>
    {
        public RSP_K31Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segments(x => x.ERR, 2);
            Segments(x => x.SFT, 3);
            Segment(x => x.UAC, 4);
            Segment(x => x.QAK, 5, x => x.Required = true);
            Segment(x => x.QPD, 6, x => x.Required = true);
            Segment(x => x.RCP, 7, x => x.Required = true);
            Groups(x => x.Response, 8, x => x.Required = true);
            Segment(x => x.DSC, 9);
        }
    }
}