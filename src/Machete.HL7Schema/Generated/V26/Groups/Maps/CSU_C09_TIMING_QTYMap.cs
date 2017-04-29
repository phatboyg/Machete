// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// CSU_C09_TIMING_QTY (GroupMap) - 
    /// </summary>
    public class CSU_C09_TIMING_QTYMap :
        HL7TemplateMap<CSU_C09_TIMING_QTY>
    {
        public CSU_C09_TIMING_QTYMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segments(x => x.TQ2, 1);
        }
    }
}