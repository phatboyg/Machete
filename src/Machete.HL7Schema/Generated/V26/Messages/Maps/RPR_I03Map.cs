// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPR_I03 (MessageMap) - 
    /// </summary>
    public class RPR_I03Map :
        HL7TemplateMap<RPR_I03>
    {
        public RPR_I03Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MSA, 3, x => x.Required = true);
            Map(x => x.Provider, 4, x => x.Required = true);
            Map(x => x.PID, 5);
            Map(x => x.NTE, 6);
        }
    }
}