// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// STC_S33 (MessageMap) - 
    /// </summary>
    public class STC_S33Map :
        HL7TemplateMap<STC_S33>
    {
        public STC_S33Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.SCP, 3, x => x.Required = true);
        }
    }
}