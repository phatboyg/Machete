// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPR_O38_TIMING (GroupMap) - 
    /// </summary>
    public class OPR_O38_TIMINGMap :
        HL7TemplateMap<OPR_O38_TIMING>
    {
        public OPR_O38_TIMINGMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segments(x => x.TQ2, 1);
        }
    }
}