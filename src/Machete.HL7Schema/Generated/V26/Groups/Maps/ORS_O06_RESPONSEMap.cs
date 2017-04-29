// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORS_O06_RESPONSE (GroupMap) - 
    /// </summary>
    public class ORS_O06_RESPONSEMap :
        HL7TemplateMap<ORS_O06_RESPONSE>
    {
        public ORS_O06_RESPONSEMap()
        {
            Group(x => x.Patient, 0);
            Groups(x => x.Order, 1, x => x.Required = true);
        }
    }
}