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
        HL7V26LayoutMap<NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT>
    {
        public NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALTMap()
        {
            Segment(x => x.NCK, 0);
            Segment(x => x.NTE, 1);
            Segment(x => x.NST, 2);
            Segment(x => x.NTE2, 3);
            Segment(x => x.NSC, 4);
            Segment(x => x.NTE3, 5);
        }
    }
}