// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SDR_S32 (MessageMap) - 
    /// </summary>
    public class SDR_S32Map :
        HL7TemplateMap<SDR_S32>
    {
        public SDR_S32Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.SDD, 3, x => x.Required = true);
            Map(x => x.SCD, 4);
        }
    }
}