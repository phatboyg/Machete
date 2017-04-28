// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RRE_O12_RESPONSE (GroupMap) - 
    /// </summary>
    public class RRE_O12_RESPONSEMap :
        HL7TemplateMap<RRE_O12_RESPONSE>
    {
        public RRE_O12_RESPONSEMap()
        {
            Map(x => x.Patient, 0);
            Map(x => x.Order, 1, x => x.Required = true);
        }
    }
}