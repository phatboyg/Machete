// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// NMD_N02_APP_STATUS (GroupMap) - 
    /// </summary>
    public class NMD_N02_APP_STATUSMap :
        HL7TemplateMap<NMD_N02_APP_STATUS>
    {
        public NMD_N02_APP_STATUSMap()
        {
            Map(x => x.NSC, 0, x => x.Required = true);
            Map(x => x.NTE, 1);
        }
    }
}