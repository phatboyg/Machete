// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORF_R04_TIMING_QTY (GroupMap) - 
    /// </summary>
    public class ORF_R04_TIMING_QTYMap :
        HL7V26LayoutMap<ORF_R04_TIMING_QTY>
    {
        public ORF_R04_TIMING_QTYMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segment(x => x.TQ2, 1);
        }
    }
}