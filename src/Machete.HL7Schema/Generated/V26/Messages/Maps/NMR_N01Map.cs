// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NMR_N01 (MessageMap) - 
    /// </summary>
    public class NMR_N01Map :
        HL7TemplateMap<NMR_N01>
    {
        public NMR_N01Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segments(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segments(x => x.ERR, 4);
            Segment(x => x.QRD, 5);
            Groups(x => x.ClockAndStatsWithNotesAlt, 6, x => x.Required = true);
        }
    }
}