// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ESR_U02 (MessageMap) - 
    /// </summary>
    public class ESR_U02Map :
        HL7TemplateMap<ESR_U02>
    {
        public ESR_U02Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EQU, 3, x => x.Required = true);
            Map(x => x.ROL, 4);
        }
    }
}