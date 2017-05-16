// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_Znn_MF_SITE_DEFINED (GroupMap) - 
    /// </summary>
    public class MFN_Znn_MF_SITE_DEFINEDMap :
        HL7LayoutMap<MFN_Znn_MF_SITE_DEFINED>
    {
        public MFN_Znn_MF_SITE_DEFINEDMap()
        {
            Segment(x => x.MFE, 0, x => x.Required = true);
            Segment(x => x.Hxx, 1, x => x.Required = true);
        }
    }
}