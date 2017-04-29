// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NMD_N02_APP_STATS (GroupMap) - 
    /// </summary>
    public class NMD_N02_APP_STATSMap :
        HL7TemplateMap<NMD_N02_APP_STATS>
    {
        public NMD_N02_APP_STATSMap()
        {
            Segment(x => x.NST, 0, x => x.Required = true);
            Segments(x => x.NTE, 1);
        }
    }
}