// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RDR_RDR_ENCODING (GroupMap) - 
    /// </summary>
    public class RDR_RDR_ENCODINGMap :
        HL7TemplateMap<RDR_RDR_ENCODING>
    {
        public RDR_RDR_ENCODINGMap()
        {
            Segment(x => x.RXE, 0, x => x.Required = true);
            Segment(x => x.TQ1, 1, x => x.Required = true);
            Segments(x => x.RXR, 2, x => x.Required = true);
            Segments(x => x.TQ2, 3);
            Segments(x => x.RXC, 4);
        }
    }
}