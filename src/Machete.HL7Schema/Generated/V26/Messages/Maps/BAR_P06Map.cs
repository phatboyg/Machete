// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// BAR_P06 (MessageMap) - 
    /// </summary>
    public class BAR_P06Map :
        HL7TemplateMap<BAR_P06>
    {
        public BAR_P06Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.EVN, 3, x => x.Required = true);
            Map(x => x.Patient, 4, x => x.Required = true);
        }
    }
}