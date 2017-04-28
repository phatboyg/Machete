// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RQP_I04 (MessageMap) - 
    /// </summary>
    public class RQP_I04Map :
        HL7TemplateMap<RQP_I04>
    {
        public RQP_I04Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.Provider, 3, x => x.Required = true);
            Map(x => x.PID, 4, x => x.Required = true);
            Map(x => x.NK1, 5);
            Map(x => x.GT1, 6);
            Map(x => x.NTE, 7);
        }
    }
}