// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORL_O36_RESPONSE (GroupMap) - 
    /// </summary>
    public class ORL_O36_RESPONSEMap :
        HL7V26LayoutMap<ORL_O36_RESPONSE>
    {
        public ORL_O36_RESPONSEMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Layout(x => x.Specimen, 1, x => x.Required = true);
        }
    }
}