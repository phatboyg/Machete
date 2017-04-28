// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SUR_P09_FACILITY_DETAIL (GroupMap) - 
    /// </summary>
    public class SUR_P09_FACILITY_DETAILMap :
        HL7TemplateMap<SUR_P09_FACILITY_DETAIL>
    {
        public SUR_P09_FACILITY_DETAILMap()
        {
            Map(x => x.FAC, 0, x => x.Required = true);
            Map(x => x.PDC, 1, x => x.Required = true);
            Map(x => x.NTE, 2, x => x.Required = true);
        }
    }
}