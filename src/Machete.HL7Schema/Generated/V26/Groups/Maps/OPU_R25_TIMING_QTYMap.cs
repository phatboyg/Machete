// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPU_R25_TIMING_QTY (GroupMap) - 
    /// </summary>
    public class OPU_R25_TIMING_QTYMap :
        HL7V26LayoutMap<OPU_R25_TIMING_QTY>
    {
        public OPU_R25_TIMING_QTYMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segment(x => x.TQ2, 1);
        }
    }
}