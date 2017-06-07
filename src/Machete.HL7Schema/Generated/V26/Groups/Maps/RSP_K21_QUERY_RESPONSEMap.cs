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
        HL7V26LayoutMap<RSP_K21_QUERY_RESPONSE>
    {
        public RSP_K21_QUERY_RESPONSEMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
            Segment(x => x.ARV, 2);
            Segment(x => x.NK1, 3);
            Segment(x => x.QRI, 4, x => x.Required = true);
        }
    }
}