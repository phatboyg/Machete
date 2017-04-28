// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_Q11_QUERY_RESULT_CLUSTER (GroupMap) - 
    /// </summary>
    public class RSP_Q11_QUERY_RESULT_CLUSTERMap :
        HL7TemplateMap<RSP_Q11_QUERY_RESULT_CLUSTER>
    {
        public RSP_Q11_QUERY_RESULT_CLUSTERMap()
        {
            Map(x => x.MFE, 0, x => x.Required = true);
            Map(x => x.LOC, 1, x => x.Required = true);
            Map(x => x.LCH, 2);
            Map(x => x.LRL, 3);
            Map(x => x.MfLocDept, 4, x => x.Required = true);
        }
    }
}