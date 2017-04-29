// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OUL_R23_TIMING_QTY (GroupMap) - 
    /// </summary>
    public class OUL_R23_TIMING_QTYMap :
        HL7TemplateMap<OUL_R23_TIMING_QTY>
    {
        public OUL_R23_TIMING_QTYMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segments(x => x.TQ2, 1);
        }
    }
}