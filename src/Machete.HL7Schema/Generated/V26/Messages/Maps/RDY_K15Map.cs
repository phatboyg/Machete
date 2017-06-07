// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDY_K15 (MessageMap) - 
    /// </summary>
    public class RDY_K15Map :
        HL7V26LayoutMap<RDY_K15>
    {
        public RDY_K15Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segment(x => x.ERR, 4);
            Segment(x => x.QAK, 5, x => x.Required = true);
            Segment(x => x.QPD, 6, x => x.Required = true);
            Segment(x => x.DSP, 7);
            Segment(x => x.DSC, 8);
        }
    }
}