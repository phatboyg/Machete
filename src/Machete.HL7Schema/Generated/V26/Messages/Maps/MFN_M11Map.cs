// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M11 (MessageMap) - 
    /// </summary>
    public class MFN_M11Map :
        HL7TemplateMap<MFN_M11>
    {
        public MFN_M11Map()
        {
            Map(x => x.MSH, 0, x => x.Required = true);
            Map(x => x.SFT, 1);
            Map(x => x.UAC, 2);
            Map(x => x.MFI, 3, x => x.Required = true);
            Map(x => x.MfTestCalculated, 4, x => x.Required = true);
        }
    }
}