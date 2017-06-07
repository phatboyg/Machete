// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RSP_E22_AUTHORIZATION_INFO (GroupMap) - 
    /// </summary>
    public class RSP_E22_AUTHORIZATION_INFOMap :
        HL7V26LayoutMap<RSP_E22_AUTHORIZATION_INFO>
    {
        public RSP_E22_AUTHORIZATION_INFOMap()
        {
            Segment(x => x.IVC, 0, x => x.Required = true);
            Segment(x => x.PSG, 1, x => x.Required = true);
            Layout(x => x.PslItemInfo, 2, x => x.Required = true);
        }
    }
}