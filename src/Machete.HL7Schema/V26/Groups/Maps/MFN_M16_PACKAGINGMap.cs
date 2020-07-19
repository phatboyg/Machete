// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// MFN_M16_PACKAGING (GroupMap) - 
    /// </summary>
    public class MFN_M16_PACKAGINGMap :
        HL7V26LayoutMap<MFN_M16_PACKAGING>
    {
        public MFN_M16_PACKAGINGMap()
        {
            Segment(x => x.PKG, 0, x => x.Required = true);
            Segment(x => x.PCE, 1);
        }
    }
}