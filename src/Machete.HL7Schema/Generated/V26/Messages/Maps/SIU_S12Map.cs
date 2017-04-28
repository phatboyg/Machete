// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SIU_S12 (MessageMap) - 
    /// </summary>
    public class SIU_S12Map :
        HL7TemplateMap<SIU_S12>
    {
        public SIU_S12Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SCH, 1, x => x.Required = true);
            Map(x => x.TQ1, 2);
            Map(x => x.NTE, 3);
            Map(x => x.Patient, 4);
            Map(x => x.Resources, 5, x => x.Required = true);
        }
    }
}