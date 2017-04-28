// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORN_O08_RESPONSE (GroupMap) - 
    /// </summary>
    public class ORN_O08_RESPONSEMap :
        HL7TemplateMap<ORN_O08_RESPONSE>
    {
        public ORN_O08_RESPONSEMap()
        {
            Map(x => x.Patient, 0);
            Map(x => x.Order, 1, x => x.Required = true);
        }
    }
}