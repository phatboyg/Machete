// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// INU_U05 (MessageMap) - 
    /// </summary>
    public class INU_U05Map :
        HL7TemplateMap<INU_U05>
    {
        public INU_U05Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EQU, 3, x => x.Required = true);
            Map(x => x.INV, 4, x => x.Required = true);
            Map(x => x.ROL, 5);
        }
    }
}