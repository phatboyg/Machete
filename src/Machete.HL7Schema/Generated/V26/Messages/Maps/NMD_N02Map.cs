// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NMD_N02 (MessageMap) - 
    /// </summary>
    public class NMD_N02Map :
        HL7TemplateMap<NMD_N02>
    {
        public NMD_N02Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.ClockAndStatsWithNotes, 3, x => x.Required = true);
        }
    }
}