// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M12_MF_OBS_ATTRIBUTES (GroupMap) - 
    /// </summary>
    public class MFN_M12_MF_OBS_ATTRIBUTESMap :
        HL7V26LayoutMap<MFN_M12_MF_OBS_ATTRIBUTES>
    {
        public MFN_M12_MF_OBS_ATTRIBUTESMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.OM1, 1, x => x.Required = true);
            Segment(x => x.OM7, 2);
        }
    }
}