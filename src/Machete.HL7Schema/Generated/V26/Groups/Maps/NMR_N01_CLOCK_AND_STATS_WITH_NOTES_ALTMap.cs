// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT (GroupMap) - 
    /// </summary>
    public class NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALTMap :
        HL7TemplateMap<NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT>
    {
        public NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALTMap()
        {
            Map(x => x.NCK, 0);
            Map(x => x.NTE, 1);
            Map(x => x.NST, 2);
            Map(x => x.NTE2, 3);
            Map(x => x.NSC, 4);
            Map(x => x.NTE3, 5);
        }
    }
}