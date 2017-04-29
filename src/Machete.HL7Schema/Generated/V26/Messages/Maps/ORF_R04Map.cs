// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORF_R04 (MessageMap) - 
    /// </summary>
    public class ORF_R04Map :
        HL7TemplateMap<ORF_R04>
    {
        public ORF_R04Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segment(x => x.QRD, 4, x => x.Required = true);
            Segment(x => x.QRF, 5);
            Groups(x => x.QueryResponse, 6, x => x.Required = true);
            Segments(x => x.ERR, 7);
            Segment(x => x.QAK, 8);
            Segment(x => x.DSC, 9);
        }
    }
}