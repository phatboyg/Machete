// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_Znn (MessageMap) - 
    /// </summary>
    public class MFN_ZnnMap :
        HL7V26LayoutMap<MFN_Znn>
    {
        public MFN_ZnnMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MFI, 3, x => x.Required = true);
            Layout(x => x.MfSiteDefined, 4, x => x.Required = true);
        }
    }
}