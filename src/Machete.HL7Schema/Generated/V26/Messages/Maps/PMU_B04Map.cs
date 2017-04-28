// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PMU_B04 (MessageMap) - 
    /// </summary>
    public class PMU_B04Map :
        HL7TemplateMap<PMU_B04>
    {
        public PMU_B04Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EVN, 3, x => x.Required = true);
            Map(x => x.STF, 4, x => x.Required = true);
            Map(x => x.PRA, 5);
            Map(x => x.ORG, 6);
        }
    }
}