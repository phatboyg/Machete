// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M17_MF_DRG (GroupMap) - 
    /// </summary>
    public class MFN_M17_MF_DRGMap :
        HL7TemplateMap<MFN_M17_MF_DRG>
    {
        public MFN_M17_MF_DRGMap()
        {
            Map(x => x.MFE, 0, x => x.Required = true);
            Map(x => x.DMI, 1, x => x.Required = true);
        }
    }
}