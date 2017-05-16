// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NMD_N02_CLOCK_AND_STATS_WITH_NOTES (GroupMap) - 
    /// </summary>
    public class NMD_N02_CLOCK_AND_STATS_WITH_NOTESMap :
        HL7LayoutMap<NMD_N02_CLOCK_AND_STATS_WITH_NOTES>
    {
        public NMD_N02_CLOCK_AND_STATS_WITH_NOTESMap()
        {
            Layout(x => x.Clock, 0);
            Layout(x => x.AppStats, 1);
            Layout(x => x.AppStatus, 2);
        }
    }
}