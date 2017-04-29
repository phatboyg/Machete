// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDR_RDR (MessageMap) - 
    /// </summary>
    public class RDR_RDRMap :
        HL7TemplateMap<RDR_RDR>
    {
        public RDR_RDRMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.MSA, 1, x => x.Required = true);
            Segments(x => x.ERR, 2);
            Segments(x => x.SFT, 3);
            Segment(x => x.SFT2, 4);
            Segment(x => x.UAC, 5);
            Groups(x => x.Definition, 6, x => x.Required = true);
            Segments(x => x.RXC, 7);
            Segment(x => x.DSC, 8);
            Segment(x => x.RXD, 9, x => x.Required = true);
            Segments(x => x.RXR, 10, x => x.Required = true);
            Segments(x => x.RXC2, 11);
            Segment(x => x.DSC2, 12);
        }
    }
}