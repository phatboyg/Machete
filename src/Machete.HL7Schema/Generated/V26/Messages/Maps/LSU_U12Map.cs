// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// LSU_U12 (MessageMap) - 
    /// </summary>
    public class LSU_U12Map :
        HL7TemplateMap<LSU_U12>
    {
        public LSU_U12Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EQU, 3, x => x.Required = true);
            Map(x => x.EQP, 4, x => x.Required = true);
            Map(x => x.ROL, 5);
        }
    }
}