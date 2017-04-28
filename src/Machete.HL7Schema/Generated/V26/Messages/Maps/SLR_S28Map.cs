// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// SLR_S28 (MessageMap) - 
    /// </summary>
    public class SLR_S28Map :
        HL7TemplateMap<SLR_S28>
    {
        public SLR_S28Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.SLT, 3, x => x.Required = true);
        }
    }
}