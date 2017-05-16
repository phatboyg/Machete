// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ORF_R04_QUERY_RESPONSE (GroupMap) - 
    /// </summary>
    public class ORF_R04_QUERY_RESPONSEMap :
        HL7LayoutMap<ORF_R04_QUERY_RESPONSE>
    {
        public ORF_R04_QUERY_RESPONSEMap()
        {
            Layout(x => x.Patient, 0);
            Layout(x => x.Order, 1, x => x.Required = true);
        }
    }
}