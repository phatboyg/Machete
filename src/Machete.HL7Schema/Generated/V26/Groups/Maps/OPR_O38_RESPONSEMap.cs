// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OPR_O38_RESPONSE (GroupMap) - 
    /// </summary>
    public class OPR_O38_RESPONSEMap :
        HL7TemplateMap<OPR_O38_RESPONSE>
    {
        public OPR_O38_RESPONSEMap()
        {
            Segments(x => x.NK1, 0, x => x.Required = true);
            Segment(x => x.PID, 1);
            Groups(x => x.Specimen, 2);
        }
    }
}