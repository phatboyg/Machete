// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_K31_TIMING_ENCODED (GroupMap) - 
    /// </summary>
    public class RSP_K31_TIMING_ENCODEDMap :
        HL7TemplateMap<RSP_K31_TIMING_ENCODED>
    {
        public RSP_K31_TIMING_ENCODEDMap()
        {
            Segment(x => x.TQ1, 0, x => x.Required = true);
            Segments(x => x.TQ2, 1);
        }
    }
}