// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M05 (MessageMap) - 
    /// </summary>
    public class MFN_M05Map :
        HL7TemplateMap<MFN_M05>
    {
        public MFN_M05Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MFI, 3, x => x.Required = true);
            Map(x => x.MfLocation, 4, x => x.Required = true);
        }
    }
}