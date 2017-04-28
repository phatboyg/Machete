// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// UDM_Q05 (MessageMap) - 
    /// </summary>
    public class UDM_Q05Map :
        HL7TemplateMap<UDM_Q05>
    {
        public UDM_Q05Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.URD, 3, x => x.Required = true);
            Map(x => x.URS, 4);
            Map(x => x.DSP, 5, x => x.Required = true);
            Map(x => x.DSC, 6);
        }
    }
}