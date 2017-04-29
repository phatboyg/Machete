// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NMQ_N01_CLOCK_AND_STATISTICS (GroupMap) - 
    /// </summary>
    public class NMQ_N01_CLOCK_AND_STATISTICSMap :
        HL7TemplateMap<NMQ_N01_CLOCK_AND_STATISTICS>
    {
        public NMQ_N01_CLOCK_AND_STATISTICSMap()
        {
            Segment(x => x.NCK, 0);
            Segment(x => x.NST, 1);
            Segment(x => x.NSC, 2);
        }
    }
}