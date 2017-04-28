// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// ESU_U01 (MessageMap) - 
    /// </summary>
    public class ESU_U01Map :
        HL7TemplateMap<ESU_U01>
    {
        public ESU_U01Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EQU, 3, x => x.Required = true);
            Map(x => x.ISD, 4);
            Map(x => x.ROL, 5);
        }
    }
}