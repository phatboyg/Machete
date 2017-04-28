// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_K21_QUERY_RESPONSE (GroupMap) - 
    /// </summary>
    public class RSP_K21_QUERY_RESPONSEMap :
        HL7TemplateMap<RSP_K21_QUERY_RESPONSE>
    {
        public RSP_K21_QUERY_RESPONSEMap()
        {
            Map(x => x.PID, 0, x => x.Required = true);
            Map(x => x.PD1, 1);
            Map(x => x.ARV, 2);
            Map(x => x.NK1, 3);
            Map(x => x.QRI, 4, x => x.Required = true);
        }
    }
}